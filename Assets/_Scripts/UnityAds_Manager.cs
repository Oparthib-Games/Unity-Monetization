using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAds_Manager : MonoBehaviour
{
    public void ShowUnityAd()
    {
        //if (Advertisement.IsReady("rewardedVideo"))
        //{
        //    var show_option_callback = new ShowOptions  // This is a CallBack  ///[.... What is a CallBack....]
        //    {
        //        resultCallback = Manage_Show_Result 
        //        //    When  the Ad finishes resultCallback will automatically call Manage_Show_Result function
        //    };

        //    Advertisement.Show("rewardedVideo", show_option_callback);
        //}
        //else
        //{
        //    UI_Manager.Update_UI("Ad is not ready.");
        //}

        var show_option_callback = new ShowOptions
        {
            resultCallback = Manage_Show_Result
        };
        Advertisement.Show("rewardedVideo", show_option_callback);
    }
    void Manage_Show_Result(ShowResult show_result) //show_result will hold wheather or not the ad is finished of skipped
    {                                                           //ShowResult is an enum
        switch(show_result)
        {
            case ShowResult.Finished:
                UI_Manager.Update_UI("You got 100 coins");
                break;
            case ShowResult.Skipped:
                UI_Manager.Update_UI("You skipped the video");
                break;
            case ShowResult.Failed:
                UI_Manager.Update_UI("Ad loading failed");
                break;
        }
    }
}
