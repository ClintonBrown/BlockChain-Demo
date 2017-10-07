﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain_Demo {
    [Serializable]
    class BlockChain {
        private List<Block> _Blocks;
        private int _blockCount = 0;

        public BlockChain() {
            Block newBlock = new Block(_blockCount, DateTime.Now, "Genesis Block", "0");
            _Blocks = new List<Block>();
            _Blocks.Add(newBlock);
            _blockCount++;
        }

        public void AddBlock(string data) {
            _Blocks.Add(new Block(_blockCount, DateTime.Now, data, LastHash));
            _blockCount++;
        }

        public List<Block> Blocks {
            get {
                return _Blocks;
            }
        }

        public string LastHash {
            get {
                return _Blocks[_Blocks.Count - 1].Hash;
            }
        }

        public int BlockCount {
            get {
                return _blockCount;
            }
        }
    }
}