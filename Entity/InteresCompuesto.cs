using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class InteresCompuesto : Intereses
    {
        public string interesCompuesto()
        {
            if (años != 0 && meses != 0 && dias != 0)
            {
                if (CapitalInicial != 0 && Interes != 0)
                {
                    return CalcularTasaInteres();//Esta revisada
                }
                if (CapitalInicial != 0 && TasaDeInteres != 0)
                {
                    return CalcularMontoCompuesto();//En mantenimiento
                }
                if (TasaDeInteres != 0 && Interes != 0)
                {
                    return CalcularCapitalInicial();//en amntenimiento
                }
                return "";//respuesta
            }
            else
            {
                if ((años != 0 && meses != 0) || (años != 0 && dias != 0) || (dias != 0 && meses != 0))
                {
                    if (CapitalInicial != 0 && Interes != 0)
                    {
                        return CalcularTasaInteres();//Esta revisada
                    }
                    if (CapitalInicial != 0 && TasaDeInteres != 0)
                    {
                        return CalcularMontoCompuesto();//En mantenimiento
                    }
                    if (TasaDeInteres != 0 && Interes != 0)
                    {
                        return CalcularCapitalInicial();//en amntenimiento
                    }
                    return "";
                }
                else
                {
                    if (dias != 0)
                    {
                        if (CapitalInicial != 0 && Interes != 0)
                        {
                            return CalcularTasaInteres();//Esta revisada
                        }
                        if (CapitalInicial != 0 && TasaDeInteres != 0)
                        {
                            return CalcularMontoCompuesto();//En mantenimiento
                        }
                        if (TasaDeInteres != 0 && Interes != 0)
                        {
                            return CalcularCapitalInicial();//en amntenimiento
                        }
                        return "";

                    }
                    else
                    {
                        if (meses != 0)
                        {
                            if (CapitalInicial != 0 && Interes != 0)
                            {
                                return CalcularTasaInteres();//Esta revisada
                            }
                            if (CapitalInicial != 0 && TasaDeInteres != 0)
                            {
                                return CalcularMontoCompuesto();//En mantenimiento
                            }
                            if (TasaDeInteres != 0 && Interes != 0)
                            {
                                return CalcularCapitalInicial();//en amntenimiento
                            }
                            return "Error Sector Meses";
                        }
                        else
                        {
                            if (años != 0)
                            {
                                if (CapitalInicial != 0 && Interes != 0)
                                {
                                    return CalcularTasaInteres();//Esta revisada
                                }
                                if (CapitalInicial != 0 && TasaDeInteres != 0)
                                {
                                    return CalcularMontoCompuesto();//En mantenimiento
                                }
                                if (TasaDeInteres != 0 && Interes != 0)
                                {
                                    return CalcularCapitalInicial();//en amntenimiento
                                }
                                return "No disponible 404";
                            }
                            else
                            {
                                if (Trimestral != 0)
                                {
                                    if (CapitalInicial != 0 && Interes != 0)
                                    {
                                        return CalcularTasaInteres();//Esta revisada
                                    }
                                    if (CapitalInicial != 0 && TasaDeInteres != 0)
                                    {
                                        return CalcularMontoCompuesto();//En mantenimiento
                                    }
                                    if (TasaDeInteres != 0 && Interes != 0)
                                    {
                                        return CalcularCapitalInicial();//en amntenimiento
                                    }
                                    return "";
                                }
                                else
                                {
                                    if (Cuatrimestral != 0)
                                    {
                                        if (CapitalInicial != 0 && Interes != 0)
                                        {
                                            return CalcularTasaInteres();//Esta revisada
                                        }
                                        if (CapitalInicial != 0 && TasaDeInteres != 0)
                                        {
                                            return CalcularMontoCompuesto();//En mantenimiento
                                        }
                                        if (TasaDeInteres != 0 && Interes != 0)
                                        {
                                            return CalcularCapitalInicial();//en amntenimiento
                                        }
                                        return "";
                                    }
                                    else
                                    {
                                        if (Semestral != 0)
                                        {
                                            if (CapitalInicial != 0 && Interes != 0)
                                            {
                                                return CalcularTasaInteres();//Esta revisada
                                            }
                                            if (CapitalInicial != 0 && TasaDeInteres != 0)
                                            {
                                                return CalcularMontoCompuesto();//En mantenimiento
                                            }
                                            if (TasaDeInteres != 0 && Interes != 0)
                                            {
                                                return CalcularCapitalInicial();//en amntenimiento
                                            }
                                            return "";
                                        }
                                        else
                                        {
                                            return CalcularTiempo();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void LimpiarVariable()
        {
            TasaDeInteres = 0;
            CapitalInicial = 0;
            Interes = 0;
            dias = 0;
            meses = 0;
            años = 0;
            Trimestral = 0;
            Semestral = 0;
            Cuatrimestral = 0;
        }
        private string CalcularCapitalInicial()//Metodo Completado
        {
            float time = (años) + (meses / 12) + (dias / 365);
            float C = (float)(Interes / Math.Pow((1 + (TasaDeInteres / 100)), time));
            if (dias != 0 && meses != 0 && años != 0)
            {
                time = (años + (meses / 12) + (dias / 365));
                C = (float)(Interes / Math.Pow((1 + (TasaDeInteres / 100)), time));
            }
            if (dias != 0 && meses != 0 && años == 0)
            {
                time = ((meses / 12) + (dias / 365));
                C = (float)(Interes / Math.Pow((1 + (TasaDeInteres / 100)), time));
            }
            if (dias != 0 && meses == 0 && años != 0)
            {
                time = (años + (dias / 365));
                C = (float)(Interes / Math.Pow((1 + (TasaDeInteres / 100)), time));
            }
            if (dias == 0 && meses != 0 && años != 0)
            {
                time = (años + (meses / 12));
                C = (float)(Interes / Math.Pow((1 + (TasaDeInteres / 100)), time));
            }
            if (Trimestral != 0)
            {
                time = (((Trimestral * 3) / 12));
                C = (float)(Interes / Math.Pow((1 + (TasaDeInteres / 100)), time));
            }
            if (Cuatrimestral != 0)
            {
                time = (((Cuatrimestral * 4) / 12));
                C = (float)(Interes / Math.Pow((1 + (TasaDeInteres / 100)), time));
            }
            if (Semestral != 0)
            {
                time = (((Semestral * 6) / 12));
                C = (float)(Interes / Math.Pow((1 + (TasaDeInteres / 100)), time));
            }

            LimpiarVariable();
            return "El Capital Inicial es De: " + Math.Round(C, 2);

        }
        private string CalcularMontoCompuesto()//Metodo Completado
        {

            float time = 0;
            float tasa = TasaDeInteres / 100;
            if (años != 0)
            {
                time = años * 12;
                tasa = tasa / 12;
            }
            if (meses != 0) time = meses;
            if(dias != 0) time = dias / 365;
            
            if (años != 0 && meses != 0 && dias == 0)
            {
                time = (((años * 12) + meses) / 12) * 12;
                tasa = (tasa / 12);
            }
            if (dias != 0 && meses != 0 && años == 0)
            {
                time = (((dias / 30) + meses) / 12) * 12;
                tasa = (tasa / 12);

            }
            if (dias != 0 && meses != 0 && años != 0)
            {
                time = (((dias / 30) + meses + (años * 12)) / 12) * 12;
                tasa = (tasa / 12);
            }
            if (dias != 0 && años != 0 && meses == 0)
            {
                time = (((dias / 30) + (años * 12)) / 12) * 12;
                tasa = (tasa / 12);
            }
            if (Trimestral != 0)
            {
                time = (((Trimestral * 3) / 12) * 12);
                tasa = (tasa / 12);

            }
            if (Cuatrimestral != 0)
            {
                time = (((Cuatrimestral * 4) / 12) * 12);
                tasa = (tasa / 12);

            }
            if (Semestral != 0)
            {
                time = (((Semestral * 6) / 12) * 12);
                tasa = (tasa / 12);

            }

            float MC = (float)(CapitalInicial * (Math.Pow((1 + tasa), time)));
            LimpiarVariable();
            return "El Monto Compuesto es De: " + Math.Round(MC,2);
        }

        private string CalcularTiempo()//Metodo Completado
        {
            float divisor = (float)Math.Log10(1 + TasaDeInteres / 100);
            float dividendo_1 = (float)(Math.Log10(Interes));
            float dividendo_2 = (float)(Math.Log10(CapitalInicial));
            float restaDividendos = dividendo_1 - dividendo_2;
            float cociente = restaDividendos / divisor;
            LimpiarVariable();
            return "El tiempo es De: " + Math.Round(cociente,2);
        }

        private string CalcularTasaInteres()//Metodo Completado
        {
            float time = (años) + (meses) + (dias / 365);
            float bases = (Interes / CapitalInicial);
            float exponente = (1 / time);
            float tasa = (float)(Math.Pow(bases, exponente) - 1) * 100;
            if (dias != 0 && meses != 0 && años != 0)
            {
                time = (1 / ((años + (meses / 12) + (dias / 365)) * 12));
                tasa = (float)((Math.Pow(bases, time) - 1) * 12) * 100;
            }
            if (dias != 0 && meses != 0 && años == 0)
            {
                time = (1 / (((meses / 12) + (dias / 365)) * 12));
                tasa = (float)((Math.Pow(bases, time) - 1) * 12) * 100;
            }
            if (dias != 0 && meses == 0 && años != 0)
            {
                time = (1 / ((años + (dias / 365)) * 12));
                tasa = (float)((Math.Pow(bases, time) - 1) * 12) * 100;
            }
            if (dias == 0 && meses != 0 && años != 0)
            {
                time = (1 / ((años + (meses / 12)) * 12));
                tasa = (float)((Math.Pow(bases, time) - 1) * 12) * 100;
            }
            if (Trimestral != 0)
            {
                time = (1 / ((((Trimestral * 3) / 12)) * 12));
                tasa = (float)((Math.Pow(bases, time) - 1) * 12) * 100;
            }
            if (Cuatrimestral != 0)
            {
                time = (1 / ((((Cuatrimestral * 4) / 12)) * 12));
                tasa = (float)((Math.Pow(bases, time) - 1) * 12) * 100;
            }
            if (Semestral != 0)
            {
                time = (1 / ((((Cuatrimestral * 6) / 12)) * 12));
                tasa = (float)((Math.Pow(bases, time) - 1) * 12) * 100;
            }
            LimpiarVariable();
            return "La Tasa de Interes es De: " + Math.Round(tasa,2) + "%";
        }

    }
}
