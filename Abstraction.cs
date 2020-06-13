using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace AbstractClass
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //Your code goes here
       Console.WriteLine("Nama\t\t: Farig Maulana Eka Putra");
       Console.WriteLine("NIM\t\t: 19.11.2748");
       Console.WriteLine("Kelas\t\t: 19 IF 03");
       
       
       Console.WriteLine();
       
       Console.WriteLine("==== OS ====");
       
       Console.WriteLine();
       
       ACOperatingSystem os;
       
       os = new MacOS();
       os.pembuat();
       os.kernel();
       os.jenis();
       
       Console.WriteLine();
       
       os = new Windows();
       os.pembuat();
       os.kernel();
       os.jenis();
       
       
       Console.WriteLine();
       
       Console.WriteLine("==== HEWAN ====");
       
       Console.WriteLine();
       
       IHewan hewan;
       
       hewan = new Sapi();
       hewan.info();
       hewan.suara();
       hewan.jenis();
       
       Console.WriteLine();
       
       hewan = new Kambing();
       hewan.info();
       hewan.suara();
       hewan.jenis();
     }
   }
   
   // Abstract Class 
   public abstract class ACOperatingSystem {
     public abstract void pembuat();
     public abstract void kernel();
     public abstract void jenis();
   }
   
   public class MacOS : ACOperatingSystem {
     public override void pembuat() {
       Console.WriteLine("Manufaktur : Apple ");
     }
     
     public override void kernel() {
       Console.WriteLine("Kernel : Darwin ");
     }
     
     public override void jenis() {
       Console.WriteLine("Jenis : Closed Source ");
     }
   }
   
   public class Windows : ACOperatingSystem {
     public override void pembuat() {
       Console.WriteLine("Manufaktur : Microsoft ");
     }
     
     public override void kernel() {
       Console.WriteLine("Kernel : Windows NT ");
     }
     
     public override void jenis() {
       Console.WriteLine("Jenis : Closed Source ");
     }
   }
   
   // Interface Class Hewan
   
   public interface IHewan{
     void info();
     void suara();
     void jenis();
   }
   
  public class Ayam : IHewan {
     public void info() {
       Console.WriteLine("Ciri Khas Sapi: ");
     }
   
     public void suara() {
       Console.WriteLine("- Bersuara Emo Emooo ");
     }
     public void jenis() {
       Console.WriteLine("- Jenis: Mamalia ");
     }
     
   } 
   
   
   public class Kucing : IHewan {
     public void info() {
       Console.WriteLine("Ciri Khas Kambing: ");
     }
     public void suara() {
       Console.WriteLine("- Bersuara Embek Embeekk");
     }
     public void jenis() {
       Console.WriteLine("- Jenis: Mamalia");
     }
     
   } 
   
 }