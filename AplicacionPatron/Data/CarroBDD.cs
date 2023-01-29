using SQLite;
using AplicacionPatron.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPatron.Data
{
    public class CarroBDD
    {
        string _dbPath;
        private SQLiteConnection conn;

        public CarroBDD(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<CarroBDD>();
        }

        public int AddCarro(Carro car)
        {
            if (car.id != 0)
                return conn.Update(car);
            else
                return conn.Insert(car);
        }

        public int DeleteCarro(Carro car)
        {
            Init();
            return conn.Delete(car);
        }

        public List<Carro> GetCarro()
        {
            Init();
            List<Carro> carros = conn.Table<Carro>().ToList();
            return carros;
        }
    }
}
