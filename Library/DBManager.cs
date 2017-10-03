using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library
{
    class DBManager
    {

        private double bauda = 0.1;

        public void remove(KnygosDataSet1 dataSet, int n)
        {
            dataSet.Table[n].Zmogus = 0;
            dataSet.Table[n][4] = DBNull.Value;
        }

        public void extend(KnygosDataSet1 dataSet, int n)
        {
            DateTime grazinimoData = (DateTime)dataSet.Table[n][4];
            if (dataSet.Table[n][4] == DBNull.Value)
            {
                throw new Exception("Knyga niekam nepriklauso");
            }
            else if (baudosDydis(grazinimoData) > 0)
            {
                throw new Exception("Negalima pratesti grazinimo datos. Bauda jau pradeta skaiciuoti.");
            }
            else
            {
                grazinimoData = grazinimoData.AddMonths(1);
                dataSet.Table[n][4] = grazinimoData;
            }

        }

        public void add(KnygosDataSet1 dataSet, String autorius, String pavadinimas)
        {
            int id = generateId(dataSet);

            DataRow anyRow = dataSet.Table.NewRow();
            anyRow[0] = id;
            anyRow[1] = autorius;
            anyRow[2] = pavadinimas;
            anyRow[3] = 0;
            dataSet.Table.Rows.Add(anyRow);
        }

        public void take(KnygosDataSet1 dataSet, int n, int ID)
        {
            DateTime Data = DateTime.Today;
            Data = Data.AddMonths(1);

            dataSet.Table[n].Zmogus = ID;
            dataSet.Table[n][4] = Data;
        }

        public double baudosDydis(DateTime data)
        {
            DateTime today = DateTime.Today;
            double suma;
            suma = (today - data).Days * this.bauda;
            if (suma > 0) return suma;
            else return 0;
        }

        private int generateId(KnygosDataSet1 knygosDataSet1)
        {
            int i;
            int id = 1000;
            for (i = 0; i < knygosDataSet1.Table.Count; i++)
            {
                if ((int)knygosDataSet1.Table[i][0] == id)
                {
                    id++;
                }
                else
                {
                    return id;
                }
            }
            return id;
        }
    }
}
