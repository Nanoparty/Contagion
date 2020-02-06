//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using WWW;

//public class Music : MonoBehaviour
//{
//    string url = "../Assets/Music/CAFM.mp3⁩";
//    // Start is called before the first frame update
//    void Start()
//    {
//       UnityWeb audioLoader = new WWW(url);
//        while (!audioLoader.isDone)
//        {
//            Debug.Log("uploading");
//        }

//        Debug.Log("1");

//        audio.clip = audioLoader.GetAudioClip(false, false, AudioType.WAV);

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (!audio.isPlaying && audio.clip.isReadyToPlay)
//        {
//            Debug.Log("playing");
//            audio.Play();
//        }

//    }
//}
