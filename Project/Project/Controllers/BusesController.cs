using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Controllers
{
    public class BusesController
    {
        public static Database db = new Database();
        public static List<Bus> getAllBus()
        {
            return db.Buses.getAllBus();
        }
        public static bool addBus(dynamic bus)
        {
            if (bus.coach.Length == 0 || bus.type.Length == 0)
            {
                MessageBox.Show("Fill all the required fields");
                return false;
            }
            return db.Buses.addBus(bus);
        }
        public static Bus searchBus(string coach)
        {
            return db.Buses.SearchBus(coach);
        }
        public static bool updateBus(dynamic bus)
        {
            if (bus.id == 0)
            {
                MessageBox.Show("Search a bus first");
                return false;
            }
            if (bus.coach.Length == 0 || bus.type.Length == 0)
            {
                MessageBox.Show("Fill all the required fields");
                return false;
            }
            return db.Buses.updateBus(bus);
        }
        public static bool deleteBus(int id)
        {
            if (id == 0)
            {
                MessageBox.Show("Search a bus first");
                return false;
            }
            return db.Buses.deleteBus(id);
        }
    }
}
