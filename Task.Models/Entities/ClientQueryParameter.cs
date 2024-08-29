using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models.Entities
{
    public class ClientQueryParameter
    {
        // Filtering Parameters
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalId { get; set; }
        public string MobileNumber { get; set; }
        public string Sex { get; set; }

        // Sorting Parameters
        public string SortBy { get; set; } // e.g., "Email", "FirstName"
        public bool Ascending { get; set; } // true for ascending, false for descending

        // Paging Parameters
        public int PageNumber { get; set; } = 1; // Default to page 1
        public int PageSize { get; set; } = 10;  // Default to 10 items per page

        // Search Suggestions Parameters
        public string SearchTerm { get; set; }
        public Guid? SuggestionId { get; set; } // Optional for tracking specific suggestions
        public DateTime? LastUsed { get; set; } // Optional for filtering suggestions by last used
    }
}
