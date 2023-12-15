using PPPROGMA.Classes.CRUD.Service;
using PPPROGMA.Classes.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPPROGMA
{
    internal static class Utils
    {
        internal static void Warning(string text, string caption = "Предупреждение")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        internal static void Success(string text, string caption = "Успешно")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void Error(string text, string caption = "Ошибка")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

         

        public static string DecimalToString(Decimal price)
        {
            string Price = price.ToString();
            for (int i = Price.Length; i < 9; i++)
            {
                Price = ' ' + Price;
            }

            return Price;
        }

        public static decimal StringToDecimal(string price)
        {
            price.Replace("₽", "").Trim(' ');
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char item in price)
            {
                if (char.IsSeparator(item) || item== '₽')
                {
                    continue;
                }
                stringBuilder.Append(item);
            }

            return decimal.Parse(stringBuilder.ToString(), NumberStyles.AllowDecimalPoint);
        }

        public static decimal CalcPriceForAllEachPeople(int TourId,int peopleCount)
        {
            try
            {
                decimal result = 0;

                List<Tour_days> daysWithTour = new List<Tour_days>();

                Tour tour = ServiceTour.UpdateTour(TourId);

                List<Services_list> services_list;
                List<General_service_list> general_service_list;
                List<Combinetion_of_tours_list> combinetion_of_tours_list;
                List<Transport_list> transport_list;
                List<Food_list> food_list;

                using (ServiceList DBWORk = new ServiceList())
                {
                    daysWithTour = DBWORk.UpdateAccomodationForOutput(TourId);
                }

                decimal ResultAcomodation = 0;
                decimal ResultService = 0;
                decimal ResultFood = 0;
                decimal ResultGeneral = 0;
                decimal ResultCombine = 0;
                decimal ResultTranport = 0;
                foreach (var day in daysWithTour)
                {
                    ResultAcomodation += day.accommodationPrice;
                    services_list = ServiceList.UpdateServices_list(day.idTour_days);
                    foreach (var item in services_list)
                    {
                        ResultService += item.ServicePrice;
                    }
                    food_list = ServiceList.Updatefood_Lists(day.idTour_days);
                    foreach (var item in food_list)
                    {
                        ResultFood += item.Food_price;
                    }
                    general_service_list = ServiceList.UpdateGeneral_service_List(day.idTour_days);
                    foreach (var item in general_service_list)
                    {
                        ResultGeneral += item.GeneralSerCost * item.general_service_listcol_count;
                    }
                    combinetion_of_tours_list = ServiceList.UpdateCombinetion_of_tours_List(day.idTour_days);
                    foreach (var item in combinetion_of_tours_list)
                    {
                        ResultCombine += item.combinetionOfToursPrice;
                    }
                    transport_list = ServiceList.UpdateTransport_list(day.idTour_days);
                    foreach (var item in transport_list)
                    {
                        ResultTranport += item.transportPrice;
                    }
                }
                result = (ResultAcomodation + ResultService + ResultFood) * peopleCount + ResultGeneral + ResultCombine + ResultTranport;
                return result;
            }
            catch (Exception)
            {
                Utils.Error("Ошибка подсчета");
                return -1;
            }
            
            
        }

        public static decimal CalcBase(int TourId, int peopleCount,out decimal cost_marja,out decimal cost_per_one,out decimal profit)
        {
            try
            {
                decimal total_cost = CalcPriceForAllEachPeople(TourId, peopleCount);
                int marja_persent = 1;

                if (peopleCount < 10)
                    marja_persent = 15;
                else if (peopleCount > 10 && peopleCount < 20)
                    marja_persent = 10;
                else if (peopleCount > 20)
                    marja_persent = 6;

                profit = (total_cost / 100) * marja_persent;
                cost_marja = total_cost + profit;
                cost_per_one = total_cost / peopleCount;
                return total_cost;
            }
            catch (Exception)
            {
                Utils.Error("Ошибка базового расчета");
                cost_marja = -1;
                profit = -1;
                cost_per_one = -1;
                return -1;
            }
           
        }
        
    }
}
