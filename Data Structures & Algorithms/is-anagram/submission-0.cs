public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> counts1 = new Dictionary<char, int>();
        Dictionary<char, int> counts2 = new Dictionary<char, int>();

        for (int i=0; i<s.Length; i++) {
            char c = s[i];
            if(counts1.ContainsKey(s[i])) {
                counts1[c] ++;
            } else {
                counts1[c] = 1;
            }
        };
        for (int i=0; i<t.Length; i++) {
            char c = t[i];
            if(counts2.ContainsKey(t[i])) {
                counts2[c] ++;
            } else {
                counts2[c] = 1;
            }
        };

        foreach (var pair in counts1) {
            if (!counts2.ContainsKey(pair.Key) || counts2[pair.Key] != pair.Value) {
                return false;
            }
        }

        return true;
    }
}
