using Alethic.Kademlia;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static async Task<int> FindPeerAsync(IKRouter<KNodeId256> router, CancellationToken cancel = default(CancellationToken))
        {
            var localPeer = new byte[32] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32 };
            var key = new KNodeId256(localPeer);
            var closestNode = await router.SelectAsync(key, k: 1, cancel);

            return 1;
        }
    }
}
