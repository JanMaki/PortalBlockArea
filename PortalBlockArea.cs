using UdonSharp;
using UnityEngine;

namespace PortalBlockArea
{
    /// <summary>
    /// ポータル設置不可エリア
    /// </summary>
    public class PortalBlockArea : UdonSharpBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            //当たったオブジェクトがポータルじゃないかを確認
            if (!other.gameObject.name.Contains("Portals/PortalInternalDynamic")) return;

            //削除
            Destroy(other.gameObject);
        }
    }
}
