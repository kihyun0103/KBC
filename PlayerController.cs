using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{ // Network 상 필수기능 상속 
  // 로컬플레이어를 정할수 있음

    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    void Update()
    {

        if (!isLocalPlayer) //나 자신의 오브젝트가 LocalPlayer가 아니라면 
        {
            return;
        }


        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            CmdFire();
        }
    }
    [Command]
    void CmdFire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        NetworkServer.Spawn(bullet);
    }

    // [Command] //클라이언트가 발사하는 척하면서 호스트가 발사
    //방장이 cmd를 실행하면 방장 컴퓨터에서만 발동 호스트는 발동 x
    //  void CmdFire()
    //  {
    //      GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

    //       bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6; // 쏘고 초당 6미터

    //      NetworkServer.Spawn(bullet); // 네트워크 방장이 불렛을 다른 호스트에 다른 클라이언트에게 소환

    //      Destroy(bullet, 2.0f); // 닿지 않으면 2초뒤에 사라짐


}


