using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM_G: MonoBehaviour

{
    public enum events
    {
        TO_MOVE, Banana, Iron_tablet, Vitamin, Bread, poision, Remaining_life, No_life_left, New_Game
    };
    public enum states { Start_game, Dead, Search_food, Levelup_yellow, Powerup_green, Healthy,
        leveldown, Gameover };

    public states CurrentState
    {
        get
        {
            return currentState;
        }
        set
        {
            currentState = value;


            StopAllCoroutines();

            switch (currentState)
            {
                case states.Start_game:
                    StartCoroutine(startgame());
                    break;
                case states.Search_food:
                    StartCoroutine(searchfood());
                    break;
                case states.Powerup_green:
                    StartCoroutine(powerup());
                    break;
                case states.Levelup_yellow:
                    StartCoroutine(levelup());
                    break;
                case states.leveldown:
                    StartCoroutine(leveldown());
                    break;
                case states.Healthy:
                    StartCoroutine(healthy());
                    break;
                case states.Dead:
                    StartCoroutine(dead());
                    break;
                case states.Gameover:
                    StartCoroutine(gameover());
                    break;



            }
        }
    }

        
        void start()
    {
                CurrentState = states.Start_game;
            }


    public IEnumerator startgame()
    {
        while (currentState == states.Start_game)
        {



        }
    }


    