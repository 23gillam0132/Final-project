/*
 * Program Name: The Ants Who Climbed Mount Floral
 * Programmer: Trevor Gillam
 * Date: 12/19/2022
 *
 * Description: TAWCMF is a game where you summon ants to journey up a mountain. The game has achievements that unlock
 * after certain conditions are met.
 * 
 */


namespace TheAntsWhoClimbedMountFloral
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}