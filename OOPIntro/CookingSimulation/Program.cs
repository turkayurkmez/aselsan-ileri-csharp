// See https://aka.ms/new-console-template for more information
using CookingSimulation;

Console.WriteLine("Hello, World!");

/*
 * 
 * Her oyuncu, aşçı rolündedir.
 * 
 * Her aşçı yemek yapar...
 */

Hamburger hamburger = new Hamburger();  
Baklava baklava = new Baklava();

Asci asci = new Asci();
asci.Pisir(hamburger);
asci.Pisir(baklava);
//baklava.SunumYap();