#include<iostream>
#include<fstream>
#include<vector>
using namespace std;

int main() {
    ifstream s;
    s.open("in.txt", ios::in);
    int n;
    s >> n; // ���ļ��ж�ȡ��һ������n
    vector<int> nums(n);

    for (int i = 0; i < n; ++i) {
        s >> nums[i];  // ��ȡÿ������
    }
    s.close(); // ��ȡ��Ϻ�ر��ļ�

    int maxNum = nums[0];
    int maxPrimeFactor = 0;

    for (int i = 0; i < n; i++) {
        int data = nums[i];
        int largestPrime = 1;
        int a = 2;

       
        while (a * a <= data) {
            while (data % a == 0) {
                data = data / a;
                largestPrime = a;
            }
            a++;
        }

    
        if (data > 1) {
            largestPrime = data;
        }

   
        if (largestPrime > maxPrimeFactor) {
            maxPrimeFactor = largestPrime;
            maxNum = nums[i];
        }
    }

    cout << maxNum;

    return 0;
}

