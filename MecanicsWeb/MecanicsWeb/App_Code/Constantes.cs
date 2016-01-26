using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Constantes
/// </summary>
public class Constantes
{
	public Constantes()
	{        
		
	}

    public class GESTION
    {
        public const string AGREGAR = "AGREGAR";
        public const string MODIFICAR = "MODIFICAR";
        public const string DETALLE = "DETALLE";
        public const string LISTAR = "LISTAR";
        public const string ELIMINAR = "ELIMINAR";
    }

    public class PARAMETRIAS
    { 
        public const int ESTADO = 1;
        public const int TIPO_DOC = 4;
        public const int GENERO = 8;
        public const int ESTADO_CIVIL = 11;
        public const int CARGO = 18;
        public const int TIPO_CONTRATO = 26;
        public const int RELACION = 33;
        public const int LOCAL = 43;
        public const int ESTADO_CONTRATO = 46;

    }

    public class SUELDOCONTRATO
    {
        public const int PlanillaTipo1 = 300;
        public const int PlanillaTipo2 = 400;
        public const int PlanillaTipo3 = 800;
        public const int LocacionTipo1 = 1100;
        public const int LocacionTipo2 = 1200;
        public const int LocacionTipo3 = 1400;

    }

    public class CrystalReport
    {
        public static string Usuario = "AppDbgen_User1";
        public static string Contraseña = "dbGeneral2015";
    }

    public class Roles
    { 
        public const string Director_de_Aprobaciones = "1";
        public const string Tesorería = "2";
        public const string Supervisor_de_Servicios_Proyectos = "3";
        public const string Administrador_del_Sistema = "4";
        public const string Usuario = "5";
        public const string Administrador_de_Usuarios = "6";
        public const string Administrador_de_Tarifas = "7";
        public const string Administrador_de_Rutas_Administrativas = "8";
        public const string Administrador_de_Rutas_de_Proyectos = "9";
        public const string Administrador_de_Rutas_de_Soporte = "10";
        public const string Administrador_de_Asignacion_de_Roles = "11";
        public const string Administrador_de_Tiempos_Máximos_de_Atención = "12";
        public const string Auditor = "13";
        public const string Revisor = "14";
    }
}
