using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float spinSpeed = 90f;
    private int getright;
    private int getleft;
    private int _leftMoveInput;
    private int _rightMoveInput;
    [SerializeField] private float offset;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float Min = -9.5f;

    [SerializeField] private Transform[] movePos;
    private int moveposIndex;
   private float Max = -4;
    private void Start()
    {
        playerTransform.position = movePos[1].position;
        moveposIndex = 1;
    }
    public void setRightInput(int leftInput)
    {
       
        getleft = leftInput;
    }

    public void setLeftMoveInput(int leftMoveInput)
    {
        _leftMoveInput = leftMoveInput;

    }
    public void setRightMoveInput(int rightMoveInput)
    {
        _rightMoveInput = rightMoveInput;
    }

    public void sayHi()
    {
        Debug.Log("hi");
    }
   
    // Update is called once per frame
    void Update()
    {
        //leftMove
        if(_leftMoveInput!=0)
        {
            /* float temp = playerTransform.position.x-offset;
             temp=Mathf.Clamp(temp, Min, Max);
             Debug.Log("Left");
             playerTransform.position = new Vector3(temp, playerTransform.position.y, playerTransform.position.z);*/

            if (moveposIndex >0)
            {
                moveposIndex--;
                playerTransform.position = movePos[moveposIndex].position;
            }
            
            /* 
             moveposIndex = math.clamp(moveposIndex, 1, 1);*/
            Debug.Log("Left");
            _leftMoveInput = 0;


        }

        //right move
        if(_rightMoveInput!=0)
        {/*
            float temp=playerTransform.position.x+offset;
            temp= Mathf.Clamp(temp, Min, Max);
            
            playerTransform.position = new Vector3(temp, playerTransform.position.y, playerTransform.position.z);*/
            if ( moveposIndex <2)
            {
                moveposIndex++;
                playerTransform.position = movePos[moveposIndex].position;
            }

            /* 
              moveposIndex = math.clamp(moveposIndex, 1, 1);*/
            Debug.Log("Right");
            _rightMoveInput = 0;
        }

        if (getleft != 0)
        {
            transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime*getleft);
        }
      

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, -spinSpeed * Time.deltaTime);
        }
    }
}
