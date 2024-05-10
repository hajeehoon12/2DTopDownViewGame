using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] public Transform player;
    [SerializeField] float smoothing = 0.2f;
    [SerializeField] Vector2 minCameraBoundary;
    [SerializeField] Vector2 maxCameraBoundary;
    public void CameraMove()
    {
        
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        
        targetPos.x = Mathf.Clamp(targetPos.x, minCameraBoundary.x, maxCameraBoundary.x); //restrict camera position
        targetPos.y = Mathf.Clamp(targetPos.y, minCameraBoundary.y, maxCameraBoundary.y);
        
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothing); //lerp for smooth camera move
    }
    

    public void CameraInitializer(GameObject playerobj)
    {
        
        player = playerobj.transform;
    }

}
