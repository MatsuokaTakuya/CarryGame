using UnityEngine;

public class WalkMove : MonoBehaviour
{
    [SerializeField]
    Rigidbody _rigidbody;
    [SerializeField]
    Animator animator;

    readonly float speed = 3.6f;

    Quaternion targetRotate;

    private void Awake()
    {
        targetRotate = transform.rotation;
    }
    private void Move()
    {
        var horizontal = Input.GetAxis("Horizontal") * speed;
        var vertical = Input.GetAxis("Vertical") * speed;

        var vec = new Vector3(horizontal, 0f, vertical);

        var blend = Mathf.Max(Mathf.Abs(horizontal), Mathf.Abs(vertical));
        animator.SetFloat("Blend", blend);
        // 一定値以上でないと向きを変わらないように設定する
        if (vec.magnitude > 0.05f)
        {
            targetRotate = Quaternion.LookRotation(vec, Vector3.up);
        }
        // To From間の回転をなめらかにする
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotate, 600 * Time.fixedDeltaTime);
        //重力の影響をなくすため元のVelocity Yを設定する
        vec.y = _rigidbody.velocity.y;
        _rigidbody.velocity = vec;
    }

    void FixedUpdate()
    {
        Move();
    }
}
