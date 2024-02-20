using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace WindowsForms_COP4365_001
{
    public partial class Form_StockViewer : Form
    {
        private List<Candlestick> candlesticks = null; // initialize null list of candlesticks to instantiate later
        private BindingList<Candlestick> boundCandlesticks = null; // initialize bindinglist to update the data shown on the chart dynamically

        //test
        //version 1.1
        public Form_StockViewer()
        {
            InitializeComponent(); //form is initialized
        }

        /// <summary>
        /// event handler for load button being clicked. OFD's dialog is shown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_loader_Click(object sender, EventArgs e) 
        {
            //shows the open file dialog upon the load button being clicked
            openFileDialog_loadTicker.ShowDialog(); 
        }


        /// <summary>
        /// This method is the event handler for a valid file being loaded in with the open file dialog. It will call the goReadFile function with the 
        /// read file and will create the list of candlesticks that will be bound to the data grid view and the chart.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog_loadTicker_FileOk(object sender, CancelEventArgs e)
        {
            //read the file, returns list of candlesticks from the file
            goReadFile();

            //filters candlesticks and adds to binding list 
            filterCandlesticks();

            //normalizes the chart axes based on the filtered candlesticks
            normalizeChart();

            //displays the candlesticks from the specified range onto the chart 
            displayCandlesticks();
        }


        /// <summary>
        /// The goReadFile method will read a given file and will return a list of candlesticks created from each line of the 
        /// csv file from the open file dialog
        /// </summary>
        /// <param name="filename">Name of the file to read</param>
        private List<Candlestick> goReadFile(string filename)
        {
            //if (filename != null) filename = openFileDialog_loadTicker.FileName;

            //assigns the first line of each csv file as the "reference string" so the method starts parsing the file from the line after that.
            const string referenceString = "Date,Open,High,Low,Close,Adj Close,Volume";

            //Start and end dates based on the date time pickers
            DateTime startDate = dateTimePicker_startDate.Value.Date;
            DateTime endDate = dateTimePicker_endDate.Value.Date;


            //Pass the file path and file name to the StreamReader constructor
            using (StreamReader sr = new StreamReader(filename)) 

            {
                //makes a list of candlestick objects to be populated with candlesticks from the read file.
                candlesticks = new List<Candlestick>();

                //clear candlestick list in case candlesticks from previous stock are in candlestick list
                candlesticks.Clear();

                //sr reads the next line of text from the file and assigns a string 'line' to that line of text. 
                string line = sr.ReadLine();

                //starts reading the file only if the line string is the reference string. This ensures it starts reading at the right place.
                if(line == referenceString)
                {
                    //continue to read until you reach end of file
                    while ((line  = sr.ReadLine()) != null)
                    {
                        //read the next line
                        //this is where we need to instantiate the candlestick represented by the string
                        Candlestick cs = new Candlestick(line);

                        //add candlesticks to list
                        candlesticks.Add(cs);
                        
                    }
                    //if (filename == null) candlesticks = candlesticks;

                    //once the file has been completely read, the list of created candlesticks is returned. This list contains all the candlesticks
                    //that could have been created from the specific file.
                    return candlesticks;

                }
                //if the first line is not the reference string, the file will not be read.
                else
                  {
                    //if this happens the form's name reads "bad file" and the name of the file that was given to the open file dialog.                
                    Text = "Bad File" + filename;

                    //returns nothing
                    return null;
                }
            }
        }

        /// <summary>
        /// default method for the goReadFile method. Calls the version that takes parameters with the openfiledialogs file name.
        /// </summary>
        private void goReadFile()
        {
            //assigns a list 'candlesticks' to the returned list from the other version of the goReadFile function.
            List<Candlestick> candlesticks = goReadFile(openFileDialog_loadTicker.FileName);
        }

        /// <summary>
        /// this method takes an unfiltered list of candlesticks from the goReadFile method and the start and end dates. Reads the candlesticks
        /// from between the start and end date and adds them to a new list of filtered candlesticks.
        /// </summary>
        /// <param name="unfilteredList">list of unfiltered candlesticks that will be filtered</param>
        /// <param name="start">start date</param>
        /// <param name="end">end date</param>
        /// <returns> Returns this filteredlist.</returns>
        private List<Candlestick> filterCandlesticks(List<Candlestick> unfilteredList, DateTime start, DateTime end)
        {
            //creates filtered list to be added to with the same size as the unfiltered list since it will be at most the same size.
            List<Candlestick> filteredList = new List<Candlestick>(unfilteredList.Count);

            //if the user inputs a starting date that is after the end date, the function returns an empty list as this shouldnt be possible.
            if (end < start)
            {
                return filteredList;
            }

            //if user inputs valid date times
            else
            {
                //iterates through all the candlesticks in the unfiltered list
                foreach (Candlestick cs in unfilteredList)
                {

                    //if start date isnt reached yet keep scanning through candlesticks
                    if (cs.date < start)
                        continue;

                    //stops when the date of the candlesticks is greater than the end date
                    if (cs.date > end)
                        break;

                    //add the candlesticks that have dates in between start and end
                    filteredList.Add(cs);
                }

                //return the list of filtered candlesticks
                return filteredList;
            }

           
        }
        /// <summary>
        /// void method for filtering a list of candlesticks. Calls the other version of the method with a list of candlesticks, and the start 
        /// and end dates as parameters.
        /// </summary>
        private void filterCandlesticks()
        {
            //assigns filteredlist to be the returned list from the call to the other version of this function
            List<Candlestick> filteredList = filterCandlesticks(candlesticks,dateTimePicker_startDate.Value,dateTimePicker_endDate.Value);

            //assigns the binding list to the filtered list of candlesticks. This will be used to dynamically update the chart and datagrid view.
            boundCandlesticks = new BindingList<Candlestick>(filteredList);
        }

        /// <summary>
        /// this method takes in a binding list of candlesticks and ties the data grid view and the chart to this bound list. DataBinds the chart.
        /// </summary>
        /// <param name="boundCandlesticks"></param>
        /// <returns>the bound list.</returns>
        private BindingList<Candlestick> displayCandlesticks(BindingList<Candlestick> boundCandlesticks)
        {
            //sets the dataGridView's data source as the binding list of candlesticks so it can be dynamically updated.
            dataGridView_tickerGrid.DataSource = boundCandlesticks;

            //these lines set the data source for the chart to the bound list, and then bind the data to the chart so it will be displayed.
            chart_candlesticks.DataSource = boundCandlesticks;
            chart_candlesticks.DataBind();

            return boundCandlesticks;
        }
        /// <summary>
        /// This method is used to display the list of candlesticks after it has been filtered.
        /// </summary>
        private void displayCandlesticks()
        {
            //calls the other version of the function with the bound list to display onto the chart
            displayCandlesticks(boundCandlesticks);
        }

        /// <summary>
        /// this method takes in a bound list and normalizes the candlestick chart to make the max and min of the y axis +- 25 of the highest
        /// high and lowest low of the candlesticks
        /// </summary>
        /// <param name="boundCandlesticks"></param>
        /// <returns></returns>
        private BindingList<Candlestick> normalizeChart(BindingList<Candlestick> boundCandlesticks) 
        {
            //initializes two decimal values
            decimal low;
            decimal high;

            //normalize chart only does anything if the list of bound candlesticks is more than 0
            if (boundCandlesticks.Count > 0)
            {
                //these two lines calculate the minimum and maximum values of the low and high properties across all the boundCandlesticks and set 
                //multiply by +- 2% to be used for the y axis max and min
                low = Math.Round(boundCandlesticks.Min(cs => cs.low) * (decimal)0.98);
                high = Math.Round(boundCandlesticks.Max(cs => cs.high) * (decimal)1.02);


                //y axis min set to low, max set to high
                chart_candlesticks.ChartAreas[0].AxisY.Minimum = (double)low;
                chart_candlesticks.ChartAreas[0].AxisY.Maximum = (double)high;

                //chart_candlesticks.ChartAreas[0].AxisY.
            }

            // binding list returned.
            return boundCandlesticks;
        }

        /// <summary>
        /// void version of the normalizeChart method. Normalizes a chart based on the boundcandlesticks list.
        /// </summary>
        private void normalizeChart()
        {
            //calls the other version with the binding list of candlesticks in order to normalize the chart.
            normalizeChart(boundCandlesticks);
        }

        /// <summary>
        /// event handler for the refresh button being clicked. Once clicked, update funtion is ran and is passed the bound candlesticks list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_refresh_Click(object sender, EventArgs e)
        {
            update(boundCandlesticks);
        }

        /// <summary>
        /// method for updating the chart when passed a binding list of candlesticks.
        /// </summary>
        /// <param name="boundCandlesticks"></param>
        /// <returns>list of bound candlesticks</returns>
        private BindingList<Candlestick> update(BindingList<Candlestick> boundCandlesticks)
        {
            //similar to the openFileDialog FileOK method, this method filters the list of candlesticks based on the start and end date,
            //normalizes, and displays the data on the chart.
            filterCandlesticks();

            normalizeChart();

            displayCandlesticks();

            //returns bound list of candlesticks
            return boundCandlesticks;
        }

        /// <summary>
        /// event handler to for clicking the day candle width radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_Day_Click(object sender, EventArgs e)
        {
            //changes the OFD's filter to show daily .csv files only.
            openFileDialog_loadTicker.Filter = "Daily|*-Day.csv";
            
        }

        /// <summary>
        /// event handler to for clicking the week candle width radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_Week_Click(object sender, EventArgs e)
        {
            //changes the OFD's filter to show weekly .csv files only.
            openFileDialog_loadTicker.Filter = "Weekly|*-Week.csv";
        }

        /// <summary>
        /// event handler to for clicking the month candle width radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_Month_Click(object sender, EventArgs e)
        {
            //changes the OFD's filter to show monthly .csv files only.
            openFileDialog_loadTicker.Filter = "Monthly|*-Month.csv";
        }
    }   
    }

