using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BARDSports.Models
{
    //BARDSports Data Initialiser is a base class and public property
    public class BARDSportsDataInitialiser : DropCreateDatabaseAlways<ApplicationDbContext> // Note: "Inheritance". This updated line is from the originally generated "BARDSportsDataInitialiser".
    {
        //create seed data
        protected override void Seed(ApplicationDbContext context)
        {
            //create premiere league 
            LeagueModel leagueModel1 = new LeagueModel();
            leagueModel1.LeagueId = 1;
            leagueModel1.LeagueName = "Premier League";
            context.LeagueModels.Add(leagueModel1);

            //create championship league 
            LeagueModel leagueModel2 = new LeagueModel();
            leagueModel2.LeagueId = 2;
            leagueModel2.LeagueName = "Championship League";
            context.LeagueModels.Add(leagueModel2);

            //create league one
            LeagueModel leagueModel3 = new LeagueModel();
            leagueModel3.LeagueId = 3;
            leagueModel3.LeagueName = "League One";
            context.LeagueModels.Add(leagueModel3);

            //create league two
            LeagueModel leagueModel4 = new LeagueModel();
            leagueModel4.LeagueId = 4;
            leagueModel4.LeagueName = "League Two";
            context.LeagueModels.Add(leagueModel4);

            //create Arsenal football club
            FootballClubModel footballClubModel1 = new FootballClubModel();            
            footballClubModel1.FootballClubId = 1;
            footballClubModel1.LeagueId = 1;
            footballClubModel1.FootballClubName = "Arsenal";
            footballClubModel1.Goals = 35;
            footballClubModel1.Passes = 40;
            footballClubModel1.Cleansheets = 19;
            footballClubModel1.Wins = 13;
            footballClubModel1.Draws = 7;
            footballClubModel1.Lost = 12;
            footballClubModel1.Points = 46;
            context.FootballClubModels.Add(footballClubModel1);

            //create Chelsea football club
            FootballClubModel footballClubModel2 = new FootballClubModel();
            footballClubModel2.FootballClubId = 2;
            footballClubModel2.LeagueId = 1;
            footballClubModel2.FootballClubName = "Chelsea";
            footballClubModel2.Goals = 32;
            footballClubModel2.Passes = 32;
            footballClubModel2.Cleansheets = 19;
            footballClubModel2.Wins = 15;
            footballClubModel2.Draws = 10;
            footballClubModel2.Lost = 7;
            footballClubModel2.Points = 55;
            context.FootballClubModels.Add(footballClubModel2);

            //create Leicester City football club
            FootballClubModel footballClubModel3 = new FootballClubModel();
            footballClubModel3.FootballClubId = 3;
            footballClubModel3.LeagueId = 1;
            footballClubModel3.FootballClubName = "Leicester City";
            footballClubModel3.Goals = 54;
            footballClubModel3.Passes = 32;
            footballClubModel3.Cleansheets = 12;
            footballClubModel3.Wins = 17;
            footballClubModel3.Draws = 5;
            footballClubModel3.Lost = 9;
            footballClubModel3.Points = 56;
            context.FootballClubModels.Add(footballClubModel3);

            //create Liverpool football club
            FootballClubModel footballClubModel4 = new FootballClubModel();
            footballClubModel4.FootballClubId = 4;
            footballClubModel4.LeagueId = 1;
            footballClubModel4.FootballClubName = "Liverpool";
            footballClubModel4.Goals = 24;
            footballClubModel4.Passes = 15;
            footballClubModel4.Cleansheets = 18;
            footballClubModel4.Wins = 15;
            footballClubModel4.Draws = 88;
            footballClubModel4.Lost = 9;
            footballClubModel4.Points = 53;
            context.FootballClubModels.Add(footballClubModel4);

            //create Manchester City football club
            FootballClubModel footballClubModel5 = new FootballClubModel();
            footballClubModel5.FootballClubId = 5;
            footballClubModel5.LeagueId = 1;
            footballClubModel5.FootballClubName = "Manchester City";
            footballClubModel5.Goals = 32;
            footballClubModel5.Passes = 21;
            footballClubModel5.Cleansheets = 25;
            footballClubModel5.Wins = 24;
            footballClubModel5.Draws = 5;
            footballClubModel5.Lost = 4;
            footballClubModel5.Points = 77;
            context.FootballClubModels.Add(footballClubModel5);

            //create Leeds United football club
            FootballClubModel footballClubModel6 = new FootballClubModel();
            footballClubModel6.FootballClubId = 6;
            footballClubModel6.LeagueId = 1;
            footballClubModel6.FootballClubName = "Leeds United";
            footballClubModel6.Goals = 32;
            footballClubModel6.Passes = 21;
            footballClubModel6.Cleansheets = 25;
            footballClubModel6.Wins = 14;
            footballClubModel6.Draws = 4;
            footballClubModel6.Lost = 14;
            footballClubModel6.Points = 46;
            context.FootballClubModels.Add(footballClubModel6);

            //create Everton football club
            FootballClubModel footballClubModel7 = new FootballClubModel();
            footballClubModel7.FootballClubId = 7;
            footballClubModel7.LeagueId = 1;
            footballClubModel7.FootballClubName = "Everton";
            footballClubModel7.Goals = 21;
            footballClubModel7.Passes = 17;
            footballClubModel7.Cleansheets = 23;
            footballClubModel7.Wins = 14;
            footballClubModel7.Draws = 7;
            footballClubModel7.Lost = 10;
            footballClubModel7.Points = 49;
            context.FootballClubModels.Add(footballClubModel7);

            //create Manchester football club
            FootballClubModel footballClubModel8 = new FootballClubModel();
            footballClubModel8.FootballClubId = 8;
            footballClubModel8.LeagueId = 1;
            footballClubModel8.FootballClubName = "Manchester United";
            footballClubModel8.Goals = 32;
            footballClubModel8.Passes = 27;
            footballClubModel8.Cleansheets = 35;
            footballClubModel8.Wins = 19;
            footballClubModel8.Draws = 9;
            footballClubModel8.Lost = 4;
            footballClubModel8.Points = 66;
            context.FootballClubModels.Add(footballClubModel8);

            //create Tottenham Hotspur football club
            FootballClubModel footballClubModel9 = new FootballClubModel();
            footballClubModel9.FootballClubId = 9;
            footballClubModel9.LeagueId = 1;
            footballClubModel9.FootballClubName = "Tottenham Hotspurs";
            footballClubModel9.Goals = 33;
            footballClubModel9.Passes = 21;
            footballClubModel9.Cleansheets = 24;
            footballClubModel9.Wins = 15;
            footballClubModel9.Draws = 8;
            footballClubModel9.Lost = 10;
            footballClubModel9.Points = 53;
            context.FootballClubModels.Add(footballClubModel9);

            //create West Ham United football club
            FootballClubModel footballClubModel10 = new FootballClubModel();
            footballClubModel10.FootballClubId = 10;
            footballClubModel10.LeagueId = 1;
            footballClubModel10.FootballClubName = "West Ham United";
            footballClubModel10.Goals = 32;
            footballClubModel10.Passes = 21;
            footballClubModel10.Cleansheets = 24;
            footballClubModel10.Wins = 16;
            footballClubModel10.Draws = 7;
            footballClubModel10.Lost = 9;
            footballClubModel10.Points = 55;
            context.FootballClubModels.Add(footballClubModel10);


            //create players Arsenal
            PlayerModel playerModel1 = new PlayerModel();
            playerModel1.FootballClubId = 1;
            playerModel1.Firstname = "Nicolas";
            playerModel1.Lastname = "Pepe";
            playerModel1.DateOfBirth = new DateTime(1989, 12, 15);
            playerModel1.Position = "Forward";
            playerModel1.Goals = 6;
            playerModel1.Assists = 10;
            playerModel1.YellowCards = 3;
            playerModel1.RedCards = 1;
            context.PlayerModels.Add(playerModel1);

            //create players Arsenal
            PlayerModel playerModel2 = new PlayerModel();
            playerModel2.FootballClubId = 1;
            playerModel2.Firstname = "Bernd";
            playerModel2.Lastname = "Leno";
            playerModel2.DateOfBirth = new DateTime(1992, 09, 18);
            playerModel2.Position = "Goal Keeper";
            playerModel2.Goals = 0;
            playerModel2.Assists = 0;
            playerModel2.YellowCards = 5;
            playerModel2.RedCards = 3;
            context.PlayerModels.Add(playerModel2);

            //create players Chelsea
            PlayerModel playerModel3 = new PlayerModel();
            playerModel3.FootballClubId = 2;
            playerModel3.Firstname = "Thiago";
            playerModel3.Lastname = "Silva";
            playerModel3.DateOfBirth = new DateTime(1994, 03, 07);
            playerModel3.Position = "Defender";
            playerModel3.Goals = 3;
            playerModel3.Assists = 10;
            playerModel3.YellowCards = 2;
            playerModel3.RedCards = 1;
            context.PlayerModels.Add(playerModel3);

           // create players Chelsea
            PlayerModel playerModel4 = new PlayerModel();
            playerModel4.FootballClubId = 2;
            playerModel4.Firstname = "Timo";
            playerModel4.Lastname = "Werner";
            playerModel4.DateOfBirth = new DateTime(1995, 06, 23);
            playerModel4.Position = "Forward";
            playerModel4.Goals = 10;
            playerModel4.Assists = 12;
            playerModel4.YellowCards = 4;
            playerModel4.RedCards = 2;
            context.PlayerModels.Add(playerModel4);

            //create players Leicester City
            PlayerModel playerModel5 = new PlayerModel();
            playerModel5.FootballClubId = 3;
            playerModel5.Firstname = "Jamie";
            playerModel5.Lastname = "Madison";
            playerModel5.DateOfBirth = new DateTime(1996, 11, 23);
            playerModel5.Position = "Midfielder";
            playerModel5.Goals = 5;
            playerModel5.Assists = 7;
            playerModel5.YellowCards = 2;
            playerModel5.RedCards = 0;
            context.PlayerModels.Add(playerModel5);

            //create players Leicester City
            PlayerModel playerModel6 = new PlayerModel();
            playerModel6.FootballClubId = 3;
            playerModel6.Firstname = "Jamie";
            playerModel6.Lastname = "Vardie";
            playerModel6.DateOfBirth = new DateTime(1987, 01, 11);
            playerModel6.Position = "Forward";
            playerModel6.Goals =10 ;
            playerModel6.Assists = 10;
            playerModel6.YellowCards = 5;
            playerModel6.RedCards = 2;
            context.PlayerModels.Add(playerModel6);

            //create players Liverpool
            PlayerModel playerModel7 = new PlayerModel();
            playerModel7.FootballClubId = 4;
            playerModel7.Firstname = "Mohammed";
            playerModel7.Lastname = "Salah";
            playerModel7.DateOfBirth = new DateTime(1992, 06, 15);
            playerModel7.Position = "Forward";
            playerModel7.Goals = 5;
            playerModel7.Assists = 6;
            playerModel7.YellowCards = 2;
            playerModel7.RedCards = 1;
            context.PlayerModels.Add(playerModel7);

            //create players Liverpool
            PlayerModel playerModel8 = new PlayerModel();
            playerModel8.FootballClubId = 4;
            playerModel8.Firstname = "Kabak";
            playerModel8.Lastname = "Ozan";
            playerModel8.DateOfBirth = new DateTime(2000, 03, 25);
            playerModel8.Position = "Defender";
            playerModel8.Goals = 3;
            playerModel8.Assists = 12;
            playerModel8.YellowCards = 4;
            playerModel8.RedCards = 3;
            context.PlayerModels.Add(playerModel8);

            //create players Manchester City
            PlayerModel playerModel9 = new PlayerModel();
            playerModel9.FootballClubId = 5;
            playerModel9.Firstname = "Segio";
            playerModel9.Lastname = "Aguero";
            playerModel9.DateOfBirth = new DateTime(1988, 06, 02);
            playerModel9.Position = "Forward";
            playerModel9.Goals = 8;
            playerModel9.Assists = 10;
            playerModel9.YellowCards = 4;
            playerModel9.RedCards = 3;
            context.PlayerModels.Add(playerModel9);

            //create players Manchester City
            PlayerModel playerModel10 = new PlayerModel();
            playerModel10.FootballClubId = 5;
            playerModel10.Firstname = "Phil";
            playerModel10.Lastname = "Foden";
            playerModel10.DateOfBirth = new DateTime(2000, 05, 28);
            playerModel10.Position = "Midfielder";
            playerModel10.Goals = 8;
            playerModel10.Assists = 10;
            playerModel10.YellowCards = 4;
            playerModel10.RedCards = 0;
            context.PlayerModels.Add(playerModel10);

            //create players Leeds United
            PlayerModel playerModel11 = new PlayerModel();
            playerModel11.FootballClubId = 6;
            playerModel11.Firstname = "Jesse";
            playerModel11.Lastname = "Lingard";
            playerModel11.DateOfBirth = new DateTime(1992, 12, 15);
            playerModel11.Position = "Midfielder";
            playerModel11.Goals = 10;
            playerModel11.Assists = 15;
            playerModel11.YellowCards = 5;
            playerModel11.RedCards = 3;
            context.PlayerModels.Add(playerModel11);

            //create players Leeds United
            PlayerModel playerModel12 = new PlayerModel();
            playerModel12.FootballClubId = 6;
            playerModel12.Firstname = "Craig";
            playerModel12.Lastname = "Dawson";
            playerModel12.DateOfBirth = new DateTime(1998, 09, 12);
            playerModel12.Position = "Defender";
            playerModel12.Goals = 5;
            playerModel12.Assists = 15;
            playerModel12.YellowCards = 4;
            playerModel12.RedCards = 1;
            context.PlayerModels.Add(playerModel12);

            //create players Everton
            PlayerModel playerModel13 = new PlayerModel();
            playerModel13.FootballClubId = 7;
            playerModel13.Firstname = "Joshua";
            playerModel13.Lastname = "King";
            playerModel13.DateOfBirth = new DateTime(1992, 01, 15);
            playerModel13.Position = "Forward";
            playerModel13.Goals = 7;
            playerModel13.Assists = 5;
            playerModel13.YellowCards = 3;
            playerModel13.RedCards = 2;
            context.PlayerModels.Add(playerModel13);

            //create players Everton
            PlayerModel playerModel14 = new PlayerModel();
            playerModel14.FootballClubId = 7;
            playerModel14.Firstname = "Jordan";
            playerModel14.Lastname = "Pickford";
            playerModel14.DateOfBirth = new DateTime(1994, 03, 07);
            playerModel14.Position = "Goalkeeper";
            playerModel14.Goals = 1;
            playerModel14.Assists = 7;
            playerModel14.YellowCards = 4;
            playerModel14.RedCards = 3;
            context.PlayerModels.Add(playerModel14);

            //create players Manchester United
            PlayerModel playerModel15 = new PlayerModel();
            playerModel15.FootballClubId = 8;
            playerModel15.Firstname = "Marus";
            playerModel15.Lastname = "Rashford";
            playerModel15.DateOfBirth = new DateTime(1997, 10, 07);
            playerModel15.Position = "Forward";
            playerModel15.Goals = 10;
            playerModel15.Assists = 7;
            playerModel15.YellowCards = 4;
            playerModel15.RedCards = 4;
            context.PlayerModels.Add(playerModel15);

            //create players Manchester United
            PlayerModel playerModel16 = new PlayerModel();
            playerModel16.FootballClubId = 8;
            playerModel16.Firstname = "Luke";
            playerModel16.Lastname = "Shaw";
            playerModel16.DateOfBirth = new DateTime(1995, 07, 12);
            playerModel16.Position = "Defender";
            playerModel16.Goals = 10;
            playerModel16.Assists = 9;
            playerModel16.YellowCards = 3;
            playerModel16.RedCards = 0;
            context.PlayerModels.Add(playerModel16);

            //create players Tottenham Hotspurs
            PlayerModel playerModel17 = new PlayerModel();
            playerModel17.FootballClubId = 9;
            playerModel17.Firstname = "Dele";
            playerModel17.Lastname = "Alli";
            playerModel17.DateOfBirth = new DateTime(1996, 04, 11);
            playerModel17.Position = "Midfielder";
            playerModel17.Goals = 6;
            playerModel17.Assists = 9;
            playerModel17.YellowCards = 3;
            playerModel17.RedCards = 0;
            context.PlayerModels.Add(playerModel17);

            //create players Tottenham Hotspurs
            PlayerModel playerModel18 = new PlayerModel();
            playerModel18.FootballClubId = 9;
            playerModel18.Firstname = "Gareth";
            playerModel18.Lastname = "Bale";
            playerModel18.DateOfBirth = new DateTime(1989, 07, 16);
            playerModel18.Position = "Forward";
            playerModel18.Goals = 10;
            playerModel18.Assists = 11;
            playerModel18.YellowCards = 1;
            playerModel18.RedCards = 0;
            context.PlayerModels.Add(playerModel18);

            //create players West Ham United
            PlayerModel playerModel19 = new PlayerModel();
            playerModel19.FootballClubId = 10;
            playerModel19.Firstname = "Vladimir";
            playerModel19.Lastname = "Coufal";
            playerModel19.DateOfBirth = new DateTime(1992, 08, 22);
            playerModel19.Position = "Defender";
            playerModel19.Goals = 9;
            playerModel19.Assists = 15;
            playerModel19.YellowCards = 6;
            playerModel19.RedCards = 3;
            context.PlayerModels.Add(playerModel19);

            //create players West Ham United
            PlayerModel playerModel20 = new PlayerModel();
            playerModel20.FootballClubId = 10;
            playerModel20.Firstname = "Aaron";
            playerModel20.Lastname = "Cresswell";
            playerModel20.DateOfBirth = new DateTime(1989, 12, 15);
            playerModel20.Position = "Defender";
            playerModel20.Goals = 5;
            playerModel20.Assists = 4;
            playerModel20.YellowCards = 3;
            playerModel20.RedCards = 2;
            context.PlayerModels.Add(playerModel20);




        }
    }
}