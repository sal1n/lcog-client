using System;
using System.Collections.Generic;
using System.Xml;

using LcogClient.Utility;
using LcogClient.Model.Collections;
using LcogClient.Model.Orders;


namespace LcogClient.Model
{
    /// <summary>
    /// Represents the player with all their objects.
    /// </summary>
    public class Player : LcogObject
    {
        #region Private Variables
        private int turn;
        private string password;
        private int energy;
        private Faction faction;
        private List<Ship> ships;
        private List<Planet> planets;
        private List<Message> messages;
        private Collections.Orders orders;
        private Technologies tech;

        #endregion

        #region Public Properties
        /// <summary>
        /// Current turn.
        /// </summary>
        public int Turn
        {
            get { return this.turn; }
            set { this.turn = value; }
        }
        /// <summary>
        /// Password.
        /// </summary>
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        /// <summary>
        /// Player faction.
        /// </summary>
        public Faction Faction
        {
            get { return this.faction; }
            set { this.faction = value; }
        }
        /// <summary>
        /// All owned ships.
        /// </summary>
        public List<Ship> Ships
        {
            get { return this.ships; }
            set { this.ships = value; }
        }
        /// <summary>
        /// All owned planets.
        /// </summary>
        public List<Planet> Planets
        {
            get { return this.planets; }
            set { this.planets = value; }
        }
        /// <summary>
        /// All messages from turn report.
        /// </summary>
        public List<Message> Messages
        {
            get { return this.messages; }
            set { this.messages = value; }
        }
        /// <summary>
        /// Stored orders.
        /// </summary>
        public Collections.Orders Orders
        {
            get { return this.orders; }
            set { this.orders = value; }
        }
        /// <summary>
        /// Total energy of the players faction.
        /// </summary>
        public int Energy
        {
            get { return this.energy; }
            set { this.energy = value; }
        }
        /// <summary>
        /// Current tech levels of the players faction.
        /// </summary>
        public Technologies Tech
        {
            get { return this.tech; }
            set { this.tech = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Player()
        {
            this.messages = new List<Message>();
            this.planets = new List<Planet>();
            this.ships = new List<Ship>();
            this.orders = new LcogClient.Model.Collections.Orders();
            this.tech = new Technologies();
        }
        #endregion

        #region Orders
        /// <summary>
        /// 
        /// </summary>
        /// <param name="faction"></param>
        /// <param name="stance"></param>
        public void Diplomacy(Faction faction, string stance)
        {
            Diplomacy d = new Diplomacy(faction, stance);
            this.orders.AddDiplomacyOrder(d);
        }
        #endregion

        public Ship GetNextShip(Ship ship)
        {
            int i = this.ships.IndexOf(ship);

            if (i == this.ships.Count - 1)
            {
                return this.ships[0];
            }
            else
            {
                return this.ships[i + 1];
            }
        }

        public Ship GetPreviousShip(Ship ship)
        {
            int i = this.ships.IndexOf(ship);

            if (i == 0)
            {
                return this.ships[this.ships.Count - 1];
            }
            else
            {
                return this.ships[i - 1];
            }
        }

        public Planet GetNextPlanet(Planet planet)
        {
            int i = this.planets.IndexOf(planet);

            if (i == this.planets.Count - 1)
            {
                return this.planets[0];
            }
            else
            {
                return this.planets[i + 1];
            }
        }

        public Planet GetPreviousPlanet(Planet planet)
        {
            int i = this.planets.IndexOf(planet);

            if (i == 0)
            {
                return this.planets[this.planets.Count - 1];
            }
            else
            {
                return this.planets[i - 1];
            }
        }
    }
}
