using System.Collections.Generic;

namespace WindowsFormsApp1 {
    class IUniversityComparer: IEqualityComparer<University> {
        // university equality by name
        bool IEqualityComparer<University>.Equals(University u1, University u2) {
            if (u1 == null && u2 == null)
                return true;
            else if (u1 == null || u2 == null)
                return false;
            else if (u1.Name.Equals(u2.Name))
                return true;
            else
                return false;
        }
        // necessary function for interface
        public int GetHashCode(University u) => u.GetHashCode();
    }
}
