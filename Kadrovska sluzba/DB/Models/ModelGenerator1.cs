// This file was automatically generated by the Dapper.SimpleCRUD T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `data source=DESKTOP-L1OSIDV\SQLEXPRESS;initial catalog=Kadrovska;Trusted_Connection=false;User ID=sa; Password=test; Connection Timeout = 0;`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `data source=DESKTOP-L1OSIDV\SQLEXPRESS;initial catalog=Kadrovska;Trusted_Connection=false;User ID=sa; Password=******;`
//     Include Views:          `True`

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Kadrovska_sluzba.DB.Models
{
    /// <summary>
    /// A class which represents the Radnik table.
    /// </summary>
	[Table("Radnik")]
	public partial class Radnik
	{
		[Key]
		public virtual int ID { get; set; }
		public virtual string JMBG { get; set; }
		public virtual string Prezime { get; set; }
		public virtual string DjevPrezime { get; set; }
		public virtual string Ime { get; set; }
		public virtual string ImeOca { get; set; }
		public virtual int Bitovi { get; set; }
		public virtual string Titula { get; set; }
		public virtual string Funkcija { get; set; }
		public virtual string MjestoRodjenja { get; set; }
		public virtual string OpstinaRodjenja { get; set; }
		public virtual DateTime? DatumRodjenja { get; set; }
		public virtual string Drzavljanstvo { get; set; }
		public virtual string Nacionalnost { get; set; }
		public virtual string PorodicnoStanje { get; set; }
		public virtual string MjestoStan { get; set; }
		public virtual string AdresaStan { get; set; }
		public virtual string OpstinaStan { get; set; }
		public virtual string TelefonStan { get; set; }
		public virtual string TelefonMob { get; set; }
		public virtual string TelefonPosao { get; set; }
		public virtual string Zanimanje { get; set; }
		public virtual string StrucnaSprema { get; set; }
		public virtual string ZavrsenaSkola { get; set; }
		public virtual string PoslovnaJedinica { get; set; }
		public virtual string RadnoMjesto { get; set; }
		public virtual string BrLK { get; set; }
		public virtual string BrRadneKnj { get; set; }
		public virtual string OpstinaIzdavanjaRK { get; set; }
		public virtual string LicniBrOsiguranja { get; set; }
		public virtual string NacinIsplate { get; set; }
		public virtual string BrTekucegRn { get; set; }
		public virtual string Banka { get; set; }
		public virtual DateTime? DatumPrvogZapos { get; set; }
		public virtual int? PrethodniStazMj { get; set; }
		public virtual int? PrethodniStazDan { get; set; }
		public virtual int? PrethodniStazUFirmiMj { get; set; }
		public virtual int? PrethodniStazUFirmiDan { get; set; }
		public virtual DateTime? DatumZapos { get; set; }
		public virtual string TipRadnogOdnosa { get; set; }
		public virtual string NacinPrestankaRO { get; set; }
		public virtual DateTime? DatumPrestankaRO { get; set; }
		public virtual string Napomena { get; set; }
		public virtual string FindStr { get; set; }
		public virtual string Lozinka { get; set; }
		public virtual byte[] Slika { get; set; }
		public virtual string Naziv { get; set; }
		public virtual string eMail { get; set; }
		public virtual IEnumerable<RadnikDjeca> RadnikDjeca { get; set; }
	}

    /// <summary>
    /// A class which represents the RadnikDjeca table.
    /// </summary>
	[Table("RadnikDjeca")]
	public partial class RadnikDjeca
	{
		[Key]
		public virtual int ID { get; set; }
		public virtual int RadID { get; set; }
		public virtual string Ime { get; set; }
		public virtual DateTime? DatumRodj { get; set; }
		public virtual string JMBG { get; set; }
		public virtual int Bitovi { get; set; }
		public virtual string Napomena { get; set; }
		public virtual Radnik Radnik { get; set; }
	}

    /// <summary>
    /// A class which represents the sysdiagrams table.
    /// </summary>
	[Table("sysdiagrams")]
	public partial class sysdiagram
	{
		public virtual string name { get; set; }
		public virtual int principal_id { get; set; }
		[Key]
		public virtual int diagram_id { get; set; }
		public virtual int? version { get; set; }
		public virtual byte[] definition { get; set; }
	}

}