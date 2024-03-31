using System;
using code.Dialoges;
using code.events;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace code.player
{
    public class PlayerCharacter : MonoBehaviour
    {
        public InputMode inputMode;
        
        public PlayerUIManager UIManager;
        public GameObject mainPlayerUI;
        [SerializeField] private float _speed;
        [SerializeField] private float _jumpForce;
        
        public Camera playerCamera;
        public Rigidbody2D _rigidbody;
        private Vector3 _input;
        [SerializeField] private SpriteRenderer _characterSprite = null;

        [SerializeField] private Vector3 _groundedOffset;

        public bool isMoving;
        public bool isFlying;
        public bool isGrounded;
        
        private void Start()
        {
            
            inputMode = InputMode.GAME;
            _rigidbody = GetComponent<Rigidbody2D>();
            UIManager = new PlayerUIManager(this, mainPlayerUI);
            UIManager.Start();
            
            PlayerEvents.OnDialogEnd += onDialogEnd;
            PlayerEvents.OnPlayerSendDialog += onDialogSend;
        }

        private void OnDestroy()
        {
            UIManager.onDestroy();
            PlayerEvents.OnDialogEnd -= onDialogEnd;
            PlayerEvents.OnPlayerSendDialog -= onDialogSend;
        }

        private void Update()
        {
            CheckGrounded();

            if (inputMode == InputMode.GAME)
            {
                Interact();
                Move();

                if (Input.GetKey(KeyCode.Space))
                {
                    if (Math.Abs(_rigidbody.velocity.y) < 0.05f)
                    {
                        Jump();
                    }
                }
            }

            UIManager.onTick();
        }


        /*
            Метод движение персонажа (Типо из название не понятно)
         */
        private void Move()
        {
            _input = new Vector2(Input.GetAxis("Horizontal"), 0);
            transform.position += _input * _speed * Time.deltaTime;

            if (_input.x != 0 && _characterSprite != null)
            {
                _characterSprite.flipX = _input.x > 0 ? false : true;
            }

            CameraMove();
        }

        /*
           Метод прыжка персонажа (Типо из название не понятно)
        */
        private void Jump()
        {
            _rigidbody.AddForce(transform.up * _jumpForce, ForceMode2D.Impulse);
        }

        
        /*
           Метод проверки кахождения персонажа на земле.
           
           Работает слудю
        */
        private void CheckGrounded()
        {
            float rayLength = 0.3f;
            Vector3 rayStartPosition = transform.position + _groundedOffset;
            RaycastHit2D hit = Physics2D.Raycast(rayStartPosition, rayStartPosition + Vector3.down, rayLength);
            
            if (hit.collider != null)
            {
                isGrounded = hit.collider.CompareTag("Ground");
            }
            else isGrounded = false;
        }

        private bool IsFlying()
        {
            if (_rigidbody.velocity.y < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void CameraMove()
        {
            Vector3 temp = playerCamera.transform.position;
            temp.x = transform.position.x;
            temp.y = transform.position.y;

            playerCamera.transform.position = temp;
        }

        private void Interact()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerEvents.SendOnPlayerInteract();
            }
        }


        private void onDialogSend(Dialog dialog)
        {
            inputMode = InputMode.DIALOG;
        }
        private void onDialogEnd()
        {
            inputMode = InputMode.GAME;
        }
    }
}