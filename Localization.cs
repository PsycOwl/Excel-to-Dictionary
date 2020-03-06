using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class Localization
{

    static bool SafeMode = true; //IF TRANSLATE ERROR, WON'T ATTEMPT TO TRANSLATE THE FAILED STRING.

    public static Dictionary<string, string> TR = new Dictionary<string, string>()
    {
		{ "EN", "TR" },
		{ "Hello", "Merhaba" },
		//Comment Line		{ "Red", "Kırmızı" },
		{ "Cyan", "Mavi" },
		{ "Yellow", "Sarı" },
		{ "Cyan", "Cam göbeği" },
		{ "", "" }
    }
    public static Dictionary<string, string> ESP = new Dictionary<string, string>()
    {
		{ "EN", "ESP" },
		{ "Hello", "Hola" },
		//Comment Line
		{ "Red", "rojo" },
		{ "Cyan", "Azul" },
		{ "Yellow", "Amarillo" },
		{ "Cyan", "Cian" },
		{ "", "" }
    }
    public static Dictionary<string, string> DE = new Dictionary<string, string>()
    {
		{ "EN", "DE" },
		{ "Hello", "Halo" },
		//Comment Line
		{ "Red", "rot" },
		{ "Cyan", "Cyan" },
		{ "Yellow", "Gelb" },
		{ "Cyan", "Cyan" },
		{ "", "" }
    }
    public static Dictionary<string, string> RU = new Dictionary<string, string>()
    {
		{ "EN", "RU" },
		{ "Hello", "Priviet" },
		//Comment Line
		{ "Red", "красный" },
		{ "Cyan", "синий" },
		{ "Yellow", "желтый" },
		{ "Cyan", "Cyan" },
		{ "", "" }
    }
    public static Dictionary<string, string> POR = new Dictionary<string, string>()
    {
		{ "EN", "POR" },
		{ "Hello", "Ola" },
		//Comment Line
		{ "Red", "Vermelho" },
		{ "Cyan", "Azul" },
		{ "Yellow", "Amarelo" },
		{ "Cyan", "Ciano" },
		{ "", "" }
    }
	public static string GetEquivalent(string value, SystemLanguage Lang)
    {
        if (SafeMode)
        {
            try
            {
                switch (Lang)
                {
                    case SystemLanguage.Turkish:
                        return TR[value];
                    case SystemLanguage.Spanish:
                        return ESP[value];
                    case SystemLanguage.German:
                        return DE[value];
                    case SystemLanguage.Russian:
                        return RU[value];
                    case SystemLanguage.Portuguese:
                        return POR[value];
                    default:
                        return value;
                }
            }
            catch (System.Exception)
            {
                //Debug.LogWarning(value);
                return value;
            }
        }
        else
        {
            switch (Lang)
            {
                case SystemLanguage.Turkish:
                    return TR[value];
                case SystemLanguage.Spanish:
                    return ESP[value];
                case SystemLanguage.German:
                    return DE[value];
                case SystemLanguage.Russian:
                    return RU[value];
                case SystemLanguage.Portuguese:
                    return POR[value];
                default:
                    return value;
            }
        }
    }

    public static string GetReversedEquivalent(string value, SystemLanguage Lang)
    {
        if (SafeMode)
        {
            try
            {
                switch (Lang)
                {
                    case SystemLanguage.Turkish:
                        return TR.ToDictionary(x => x.Value, x => x.Key)[value];
                    case SystemLanguage.Spanish:
                        return ESP.ToDictionary(x => x.Value, x => x.Key)[value];
                    case SystemLanguage.German:
                        return DE.ToDictionary(x => x.Value, x => x.Key)[value];
                    case SystemLanguage.Russian:
                        return RU.ToDictionary(x => x.Value, x => x.Key)[value];
                    case SystemLanguage.Portuguese:
                        return POR.ToDictionary(x => x.Value, x => x.Key)[value];
                    default:
                        return value;
                }
            }
            catch (System.Exception)
            {
                //Debug.LogWarning(value);
                return value;
            }
        }
        else
        {
            switch (Lang)
            {
                case SystemLanguage.Turkish:
                    return TR.ToDictionary(x => x.Value, x => x.Key)[value];
                case SystemLanguage.Spanish:
                    return ESP.ToDictionary(x => x.Value, x => x.Key)[value];
                case SystemLanguage.German:
                    return DE.ToDictionary(x => x.Value, x => x.Key)[value];
                case SystemLanguage.Russian:
                    return RU.ToDictionary(x => x.Value, x => x.Key)[value];
                case SystemLanguage.Portuguese:
                    return POR.ToDictionary(x => x.Value, x => x.Key)[value];
                default:
                    return value;
            }
        }
    }
}
