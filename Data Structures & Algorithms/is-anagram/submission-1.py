class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        dictionary_1 = {}
        dictionary_2 = {}

        for x in range(len(s)):
            if s[x] in dictionary_1.keys():
                dictionary_1[s[x]] = dictionary_1[s[x]] + 1
            else:
                dictionary_1[s[x]] = 1

        for x in range(len(t)):
            if t[x] in dictionary_2.keys():
                dictionary_2[t[x]] = dictionary_2[t[x]] + 1
            else:
                dictionary_2[t[x]] = 1

        return dictionary_1 == dictionary_2



