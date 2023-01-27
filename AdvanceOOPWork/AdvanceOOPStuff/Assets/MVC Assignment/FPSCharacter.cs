using UnityEngine;

public class FPSCharacter : PlatformerElement
{

    void Start()
    {
        Debug.Log(app);
        if (app.platformerModel.FPSModel.lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * app.platformerModel.FPSModel.lookSensitivity, 0);
        app.platformerModel.FPSModel.xRotation -= Input.GetAxis("Mouse Y") * app.platformerModel.FPSModel.lookSensitivity;
        app.platformerModel.FPSModel.xRotation = Mathf.Clamp(app.platformerModel.FPSModel.xRotation, -app.platformerModel.FPSModel.maxUpRotation, app.platformerModel.FPSModel.maxDownRotation);
        app.platformerModel.FPSModel.cam.localRotation = Quaternion.Euler(app.platformerModel.FPSModel.xRotation, 0, 0);

        app.platformerModel.FPSModel.velocity.z = Input.GetAxis("Vertical") * app.platformerModel.FPSModel.walkSpeed;
        app.platformerModel.FPSModel.velocity.x = Input.GetAxis("Horizontal") * app.platformerModel.FPSModel.strafeSpeed;
        app.platformerModel.FPSModel.velocity = transform.TransformDirection(app.platformerModel.FPSModel.velocity);

        if (Input.GetKey(app.platformerModel.FPSModel.sprintKey)) { Sprint(); }

        // Apply manual gravity
        app.platformerModel.FPSModel.velocity.y += Physics.gravity.y * Time.deltaTime;

        if (app.platformerModel.FPSModel.controller.isGrounded && app.platformerModel.FPSModel.velocity.y < 0) { Land(); }

        if (Input.GetButtonDown("Jump"))
        {
            if (app.platformerModel.FPSModel.controller.isGrounded)
            {
                Jump();
            }
            else if (app.platformerModel.FPSModel.jumpsSinceLastLand < app.platformerModel.FPSModel.maxJumps)
            {
                Jump();
            }
        }

        app.platformerModel.FPSModel.controller.Move(app.platformerModel.FPSModel.velocity * Time.deltaTime);
    }

    private void Sprint()
    {
        app.platformerModel.FPSModel.velocity.z *= app.platformerModel.FPSModel.sprintFactor;
        app.platformerModel.FPSModel.velocity.x *= app.platformerModel.FPSModel.sprintFactor;
    }

    private void Jump()
    {
        app.platformerModel.FPSModel.velocity.y = Mathf.Sqrt(app.platformerModel.FPSModel.jumpHeight * -2 * Physics.gravity.y);
        app.platformerModel.FPSModel.jumpsSinceLastLand++;
    }

    private void Land()
    {
        app.platformerModel.FPSModel.velocity.y = 0;
        app.platformerModel.FPSModel.jumpsSinceLastLand = 0;
    }
}
