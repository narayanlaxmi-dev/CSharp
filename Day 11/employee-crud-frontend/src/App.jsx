import React, { useEffect, useState } from "react";
import axios from "axios";

function App() {
  const [employees, setEmployees] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    axios
      .get("https://localhost:7029/api/Employees")
      .then((response) => {
        setEmployees(response.data);
        setLoading(false);
      })
      .catch((err) => {
        setError(err.message || "Error fetching employees");
        setLoading(false);
      });
  }, []);

  if (loading) return <p>Loading employees...</p>;
  if (error) return <p>Error: {error}</p>;

  return (
    <div>
      <h2>Employees List</h2>
      <ul>
        {employees.map((emp) => (
          <li key={emp.id}>
            <strong>{emp.name}</strong> - {emp.department} - {emp.email} - $
            {emp.salary}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
