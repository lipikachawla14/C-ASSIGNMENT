using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExpediaProject.CommonUtills;
using ExpediaProject.PageReposistory;

namespace ExpediaProject.BusinessLogic
{
    class FlightBL: Driver
    {
        FlightSelectionPage fsPage;
        TripPage tpPage;
        CommonUtilities commonuitils;
        private static double fare = 0.00f;
        private static String FirstStation = "Luqa, Malta (MLA)", SecondStation = "London, England, UK (LON)", ThirdStation = "Rome, Italy (ROM)", FirstDate = "02/17/2020", SecondDate = "02/20/2020", ThirdDate = "02/24/2020", number = " ";
        public bool CheckTitle(String title)
        {
            commonuitils = new CommonUtilities();
            InvokeDriver();
            return commonuitils.CheckTitle(title);
        }
        public bool clickFlights()
        {
            try
            {
                fsPage = new FlightSelectionPage();
                commonuitils.click(fsPage.getFlightsButton());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool clickMultiCity()
        {
            try
            {
                commonuitils.click(fsPage.getMultiCityLBL());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddFlight()
        {
            try
            {
                commonuitils.click(fsPage.getAddFlightOPT());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool fillupFlightData(string FirstStation, string SecondStation, string ThirdStation, string FirstDate, string SecondDate, string ThirdDate, string number)
        {
            try
            {

                commonuitils.click(fsPage.getFirstAirport());
                commonuitils.TypeText(fsPage.getFirstAirport(), FirstStation);
                commonuitils.click(fsPage.getFirstDestinationAirport());
                commonuitils.TypeText(fsPage.getFirstDestinationAirport(), SecondStation);
                commonuitils.click(fsPage.getFirstDate());
                commonuitils.TypeText(fsPage.getFirstDate(), FirstDate);
                commonuitils.click(fsPage.getTravellersValue());
                FlightBL.number = number;

                for (int i = 1; i < int.Parse(number); i++)
                {
                    commonuitils.click(fsPage.getAddTravellerButton());
                }
                commonuitils.click(fsPage.getAdultSelectorCloseButton());
                commonuitils.click(fsPage.getSecondAirport());
                commonuitils.TypeText(fsPage.getSecondAirport(), SecondStation);
                commonuitils.click(fsPage.getSecondDestinationAirport());
                commonuitils.TypeText(fsPage.getSecondDestinationAirport(), ThirdStation);
                commonuitils.click(fsPage.getSecondDate());
                commonuitils.TypeText(fsPage.getSecondDate(), SecondDate);
                commonuitils.click(fsPage.getThirdAirport());
                commonuitils.TypeText(fsPage.getThirdAirport(), ThirdStation);
                commonuitils.click(fsPage.getThirdDestinationAirport());
                commonuitils.TypeText(fsPage.getThirdDestinationAirport(), FirstStation);
                commonuitils.click(fsPage.getSecondDate());
                commonuitils.TypeText(fsPage.getThirdDate(), ThirdDate);

                return true;
            }
            catch (Exception e)
            {

                return false;
                throw e;

            }
        }
        public bool ClickSearch()
        {
            try
            {
                commonuitils.click(fsPage.getSearchButton());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool verifyEntry()
        {
            tpPage = new TripPage();
            bool flag = true;
            flag = commonuitils.getValue(tpPage.getDepart1()).Contains(FlightBL.FirstStation);

            flag = commonuitils.getValue(tpPage.getDepart2()).Contains(FlightBL.SecondStation);

            flag = commonuitils.getValue(tpPage.getDepart3()).Contains(FlightBL.ThirdStation);

            flag = commonuitils.getValue(tpPage.getDate1()).Contains(FlightBL.FirstDate);

            flag = commonuitils.getValue(tpPage.getDate2()).Contains(FlightBL.SecondDate);

            flag = commonuitils.getValue(tpPage.getDate3()).Contains(FlightBL.ThirdDate);
            if (flag == true)
            {
                return true;
            }
            else return false;
        }
        public void SelectFlights()
        {

            commonuitils.switchWindow();

            Thread.Sleep(2000);
            FlightBL.fare = commonuitils.getFare1(tpPage.getSelectButton());
            commonuitils.click(tpPage.getSelectButton());
            commonuitils.wait();
            commonuitils.switchWindow();
            commonuitils.click(tpPage.getSelectButton());
            commonuitils.switchWindow();
            commonuitils.wait();
            commonuitils.click(tpPage.getSelectButton());

        }
        public bool verifyTotal()
        {
            commonuitils.wait();
            double total = FlightBL.fare * double.Parse(number);
            //a.WriteLine(total);
            commonuitils.SwitchTabs();
            commonuitils.wait();

            if (total == commonuitils.getFare(tpPage.getTotalFare()))
            {
                return true;
            }
            else return false;
        }
    }
}
