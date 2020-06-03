using System;


namespace part4
{
    public class Order
    {
        int[] preorder;
        int[] inorder;
        int[] result;
        int[] nodeLocationInOrder;
        public int[] Create(int[] a, int[] b)
        {
            this.preorder = a;
            this.inorder = b;
            int n = preorder.Length;
            result = new int[n];

            nodeLocationInOrder = new int[n+1];
            for (int i = 0; i < n; i++)
            {
                nodeLocationInOrder[inorder[i]] = i;
            }
            FormPostOrder(0, n -1, 0, n- 1, 0, n -1);
            return result;
        }
        void FormPostOrder(int pOFirst, int pOLast, int iOFirst, int iOLast, int poOFirst, int poOLast)
        {
            if (pOFirst > pOLast) return;
            int root = preorder[poOFirst];
            result[poOLast] = root;
            int location = nodeLocationInOrder[root];
            int amount = location - iOFirst;
            FormPostOrder(pOFirst + 1, pOFirst + 1 + amount -1, iOFirst, iOFirst + amount -1, poOFirst, poOFirst + amount -1,);
            FormPostOrder(pOFirst + 1 + amount, pOLast, location + 1, iOLast, poOFirst + amount, poOLast -1);

        }
    }
}