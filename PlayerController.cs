using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControlller : MonoBehaviour
 {
     //インスペクターで設定する
     public float speed; //速度
     public float gravity; //重力
     public float jumpSpeed;//ジャンプする速度
     public float jumpHeight;//高さ制限

     //プライベート変数
     private Animator anim = null;
     private Rigidbody2D rb = null;
     private bool isGround = false;
     private bool isJump = false;
     private float jumpPos = 0.0f;

     void Start()
     {
         Debug.Log(114514);
          //コンポーネントのインスタンスを捕まえる
          anim = GetComponent<Animator>();
          rb = GetComponent<Rigidbody2D>();
      }

      void FixedUpdate()
      {
          //接地判定を得る

          //キー入力されたら行動する
          float horizontalKey = Input.GetAxis("Horizontal");
          float xSpeed = 0.0f;
          float ySpeed = -gravity;
          float verticalKey = Input.GetAxis("Vertical");

          if (isGround)
          {
              if (verticalKey > 0)
              {
                  ySpeed = jumpSpeed;
                  jumpPos = transform.position.y; //ジャンプした位置を記録する
                  isJump = true;
              }
              else
              {
                  isJump = false;
              }
          }
          else if (isJump)
          {
              //上ボタンを押されている。かつ、現在の高さがジャンプした位置から自分の決めた位置より下ならジャンプを継続する
              if (verticalKey > 0 && jumpPos + jumpHeight > transform.position.y)
              {
                  ySpeed = jumpSpeed;
              }
              else
              {
                  isJump = false;
              }
          }
          if (horizontalKey > 0)
          {
              transform.localScale = new Vector3(1, 1, 1);
              anim.SetBool("run", true);
              xSpeed = speed;
          }
          else if (horizontalKey < 0)
          {
              transform.localScale = new Vector3(-1, 1, 1);
              anim.SetBool("run", true);
              xSpeed = -speed;
          }
          else
          {
              anim.SetBool("run", false);
              xSpeed = 0.0f;
          }
          rb.velocity = new Vector2(xSpeed, ySpeed);
      }
 }