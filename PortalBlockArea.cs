using UdonSharp;
using UnityEngine;

namespace PortalBlockArea
{
    /// <summary>
    /// ポータル設置不可エリア
    /// </summary>
    [RequireComponent(typeof(Collider))]
    public class PortalBlockArea : UdonSharpBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            //当たったオブジェクトがポータルじゃないかを確認
            if (!other.gameObject.name.Contains("PortalInternal") 
                && !other.gameObject.name.Contains("PortalSelector")) return;
            
            //削除
            Destroy(other.gameObject);
        }
    }
}
