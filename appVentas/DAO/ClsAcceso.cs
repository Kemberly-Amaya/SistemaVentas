using appVentas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVentas.DAO
{
    class ClsAcceso
    {
        //Consulta trayendo la conecion a la bd
        public int acceso(String usuario, String Password) {
            //trabajando con linq
            int variabledeacceso = 0;
            using (sistema_ventasEntities bd = new sistema_ventasEntities()) {
                var consulta = from user in bd.tb_usuario
                               where user.email == usuario && user.contrasena == Password
                               select user;
                //Ya le pasamos los paramétros

                //Usamos Count ---contar cuantos registros trae la consulta
                //consulta devuelve tipo List-- y List permite utilizar Count
                if(consulta.Count() > 0){

                //Mayor que cero que nos traiga lo que esta en la base de datos y se vuelve 1
                    variabledeacceso = 1;

                }
            
            
            }
                return variabledeacceso;
        
        }
    }
}
