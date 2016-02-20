using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Constantes
{
    public Constantes()
    {

    }

    public class ACCION
    {
        public const string AGREGAR = "AGREGAR";
        public const string MODIFICAR = "MODIFICAR";
    }

    public class PARAMETRIAS
    {
        public const int ESTADO = 1;
        public const int TIPO_DOC = 4;
        public const int GENERO = 8;
        public const int ESTADO_CIVIL = 11;
        public const int MARCA = 18;
        public const int TIPO_PERSONA = 49;

    }

    public class CrystalReport
    {
        public static string Usuario = "Administrador";
        public static string Contraseña = "admin";
    }

    public class Roles
    {
        public const string Administrador_del_Sistema = "1";
    }
}