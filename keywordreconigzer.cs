using System;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class keywordreconigzer : MonoBehaviour
{

    [SerializeField]
    private string[] m_Keywords;
   
    private KeywordRecognizer m_Recognizer;

    void Start()
    {
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        controllercommand.keywordsstart += startKey;
        controllercommand.keywordsstop += stopKey;
    }

    void startKey() {
        m_Recognizer.Start();
    }

    void stopKey() {
        m_Recognizer.Stop();
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());
        if (args.text == "abrir") {
            abrirPuertas.evento_abrir();
        } else if (args.text == "cerrar") {
            abrirPuertas.evento_cerrar();
        } else if (args.text == "noche") {
            DiaNoche.evento_noche();
        } else if (args.text == "dia") {
            DiaNoche.evento_dia();
        } else if (args.text == "encender") {
            Interruptor.evento_encender();
        } else if (args.text == "apagar") {
            Interruptor.evento_apagar();
        } else if (args.text == "deshacer") {
            Cama.deshacer();
        } else if (args.text == "hacer") {
            Cama.hacer();
        }
    }
}

public static class abrirPuertas {
    public static Action evento_abrir;
    public static Action evento_cerrar;
    
}

public static class DiaNoche {
    public static Action evento_noche;
    public static Action evento_dia;
}

public static class Interruptor {
    public static Action evento_encender;
    public static Action evento_apagar;
}

public static class Cama {
    public static Action deshacer;
    public static Action hacer;
}