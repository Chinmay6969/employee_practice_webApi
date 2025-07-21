//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BAL
//{
//    public class factory
//    {

//        //public factory(Ivehicle obj) 
//        //{ 
//        //    //it will create vehicle based on obj
//        //}

//        public Ivehicle createVehicle(Ivehicle ivehicle)
//        {

//            ivehicle.createBrake();
//            ivehicle.createEngine();

//            return ivehicle;

//        }

        
//    }

//    public class autoo
//    {

//    }

//    public interface Ivehicle 
//    {
//        public void createBrake();
//        public void createEngine();
//        public void createCabin();
//    }

//    public class car: Ivehicle
//    {
//        public int wheel { get; set; }
//        public int engine { get; set; }

//        public int brake { get; set; }
//        public void createEngine()
//        {
//            Console.WriteLine("Print A");
//        }

//        public void createCabin()
//        {
//            Console.WriteLine("Print A");
//        }

//        public void createBrake()
//        {

//        }
//    }

//    public class Bike : Ivehicle
//    {
//        public void print()
//        {
//            Console.WriteLine("Print B");
//        }
//    }

//    public class truck : Ivehicle
//    {
//        public void print()
//        {
//            Console.WriteLine("Print C");
//        }
//    }
//}
