using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.Language
{
    public class Operations : IEnumerable<Operation>
    {
        private readonly List<Operation> _operations = new List<Operation>();

        public void Add(Operation operation)
        {
            _operations.Add(operation);
        }

        public Operation WithName(string operationName)
        {
            return _operations.FirstOrDefault(op => op.Name == operationName);
        }

        public IEnumerator<Operation> GetEnumerator()
        {
            return _operations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}