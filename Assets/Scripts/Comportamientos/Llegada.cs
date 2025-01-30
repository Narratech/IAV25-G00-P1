/*    
   Copyright (C) 2020-2025 Federico Peinado
   http://www.federicopeinado.com

   Este fichero forma parte del material de la asignatura Inteligencia Artificial para Videojuegos.
   Esta asignatura se imparte en la Facultad de Inform�tica de la Universidad Complutense de Madrid (Espa�a).

   Autor: Federico Peinado 
   Contacto: email@federicopeinado.com
*/
using UnityEngine;

namespace UCM.IAV.Movimiento
{
    /// <summary>
    /// Clase para modelar el comportamiento de SEGUIR a otro agente
    /// </summary>
    public class Llegada : ComportamientoAgente
    {
        /// <summary>
        /// Obtiene la direcci�n
        /// </summary>
        /// <returns></returns>


        // El radio para llegar al objetivo
        public float rObjetivo;

        // El radio en el que se empieza a ralentizarse
        public float rRalentizado;

        public float fRalentizado;

        public int distancia = 7;

        // El tiempo en el que conseguir la aceleracion objetivo
        float timeToTarget = 0.1f;
        public override ComportamientoDireccion GetComportamientoDireccion()
        {
            // IMPLEMENTAR llegada
            timeToTarget = 0.1f; //por ejemplo
            return new ComportamientoDireccion();
        }


    }
}
