using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class TimeScriptBridge : MonoBehaviour
{
   public GameObject timeTextObject;
       string url = "https://timeapi.io/api/Time/current/zone?timeZone=Asia/Ho_Chi_Minh";

    public class APITime
    {
        public int year;
        public int month;
        public int day;
        public int hour;
        public int minute;
        public int seconds;
        public int milliSeconds;
        public string dateTime;
        public string date;
        public string time;
        public string timeZone;
        public string dayOfWeek;
        public bool dstActive;
    }

    void Start()
    {

    // wait a couple seconds to start and then refresh every second

       InvokeRepeating("GetTime", 2f, 1f);
   }

   void GetTime()
   {

       StartCoroutine(GetRequest(url));
   }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();


            if (webRequest.result ==  UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(": Error: " + webRequest.error);
            }
            else
            {
                // print out the time data to make sure it makes sense
                Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);

                var text = webRequest.downloadHandler.text;
                APITime time =JsonUtility.FromJson<APITime>(text);
                timeTextObject.GetComponent<TextMeshPro>().text = "" + time.hour + ":" + time.minute;
            }
        }
    }
}
