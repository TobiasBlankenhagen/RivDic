﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RivDic
{
    /// ============================================================================================================================
    class Constants
    {
        /// <summary></summary>
        public const string River = "River";
        /// <summary></summary>
        public const string Route = "Route";
        /// <summary></summary>
        public const string StartEnd = "StartEnd";

        #region Datenbank

        /// <summary> Konstante für den Speicherplatz der Datenbank</summary>
        public const string DbPath = "DatabasePath";
        /// <summary> Konstante für den User</summary>
        public const string DbUser = "DatabaseUser";
        /// <summary> Konstante für das Passwort</summary>
        public const string DbPassword = "DatabasePassword";

        #endregion Datenbank
    }

    /// ============================================================================================================================
    public class Tbl
    {
        /// <summary></summary>
        public const string Fluesse = "FLUESSE";
        /// <summary></summary>
        public const string FlussAbschnitt = "FLUSSABSCHNITT";
        /// <summary></summary>
        public const string Laender = "LAENDER";
        /// <summary></summary>
        public const string StartEnde = "STARTENDE";

    }

    /// ============================================================================================================================
    public class Fld
    {
        /// <summary>Id</summary>
        public const string Id = "ID";
        /// <summary>Wildwasser Level</summary>
        public const string WWLevel = "WWLEVEL";
        /// <summary>Name</summary>
        public const string Name = "NAME";
        /// <summary>Land</summary>
        public const string Land = "LAND";
        /// <summary>Ticket Ja/Nein</summary>
        public const string Ticket = "TICKET";
        /// <summary>Ticketpreis</summary>
        public const string Ticketpreis = "TICKETPREIS";
        /// <summary>Änderungsdatum</summary>
        public const string DatAend = "DATAEND";
        /// <summary>Id des Flusses</summary>
        public const string FlussId = "FLUSSID";
        /// <summary>Einsetzpunkt</summary>
        public const string Einsetzpunkt = "EINSETZPUNKT";
        /// <summary>Aussetzpunkt</summary>
        public const string Aussetzpunkt = "AUSSETZPUNKT";
        /// <summary>Kommentar</summary>
        public const string Kommentar = "KOMMENTAR";
        /// <summary>Koordinaten</summary>
        public const string Koordinaten = "KOORDINATEN";
    }

    public class Key
    {
        /// <summary>Fremdschlüssel Flussabschnitt zu StartEnde auf Feld Einsetzpunkt</summary>
        public const string FkFlussAbschnittToStartEnde_1 = "FK_STARTENDE_1";
        /// <summary>Fremdschlüssel Flussabschnitt zu StartEnde auf Feld Aussetzpunkt</summary>
        public const string FkFlussAbschnittToStartEnde_2 = "FK_STARTENDE_2";
        /// <summary>Fremdschlüssel Flussabschnitt zu Fluesse auf Feld FlussId</summary>
        public const string FkFlussAbschnittToFluesse_1 = "FK_FLUESSE_1";

    }
}
