﻿namespace Sireed.API.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string MotDePasse { get; set; }
        public string Role { get; set; }
    }
}