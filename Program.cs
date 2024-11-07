//*****************************************************************************
//** 2275. Largest Combination With Bitwise AND Greater Than Zero   leetcode **
//*****************************************************************************


int largestCombination(int* candidates, int candidatesSize) {
    const int BITS = 24;
    
    int maxCount = 0;

    for (int i = 0; i < BITS; i++) {
        int bitCount = 0; 

        for (int j = 0; j < candidatesSize; j++) {
            if ((candidates[j] >> i) & 1) {
                bitCount++;
            }
        }
        
        if (bitCount > maxCount) {
            maxCount = bitCount;
        }
    }
    
    return maxCount;
}