using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gley.GameServices;

public class GameServices : MonoBehaviour
{
    public void Login()
    {
        Gley.GameServices.API.LogIn();
    }

    public void SubmitAchievement()
    {
        Gley.GameServices.API.SubmitAchievement(AchievementNames.Achievement1);
        Gley.GameServices.API.SubmitAchievement(AchievementNames.Achievement2);
    }

    public void ShowAchievementsUI()
    {
        Gley.GameServices.API.ShowAchievementsUI();
    }

    public void SubmitScore()
    {
        long score = 1000;

        Gley.GameServices.API.SubmitScore(score, LeaderboardNames.Leaderboard);
    }

    public void ShowLeaderboardsUI()
    {
        Gley.GameServices.API.ShowLeaderboadsUI();
    }
}
