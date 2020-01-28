using System;

//Mario erft nu de Classes/Functions van character
public class Star : Character
{

    public string Uspeed1 = "Mario is going";
    public string Uspeed2 = "mp/h.";


  //function override
 public  void Invincible()
 {
   Console.WriteLine("Mario is now invincible, he can't take damage!");
 }




}