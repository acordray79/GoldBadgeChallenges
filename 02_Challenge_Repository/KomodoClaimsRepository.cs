using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge_Repository
{
    public class KomodoClaimsRepository
    {
        private Queue<KomodoClaims> _claimQueue = new Queue<KomodoClaims>();

        public Queue<KomodoClaims> GetAllQueue()
        {
            return _claimQueue;
        }
        public KomodoClaims PeekNextContent()
        {
                return _claimQueue.Peek();
        }
        public KomodoClaims GetNextContent()
        {
            KomodoClaims nextContent = _claimQueue.Dequeue();
            return nextContent;
        }
        public void AddToQueue(KomodoClaims content)
        {
            _claimQueue.Enqueue(content);
        }
    }
}
