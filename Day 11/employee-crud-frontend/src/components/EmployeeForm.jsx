import { useState, useEffect } from "react";

const initialState = {
  name: "",
  department: "",
  email: "",
  salary: "",
};

export default function EmployeeForm({ addOrEdit, current }) {
  const [formData, setFormData] = useState(initialState);

  useEffect(() => {
    if (current) setFormData(current);
  }, [current]);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    addOrEdit(formData); // formData should include id if editing
    setFormData(initialState);
  };

  return (
    <form onSubmit={handleSubmit}>
      <input
        name="name"
        value={formData.name}
        onChange={handleChange}
        placeholder="Name"
        required
      />
      <input
        name="department"
        value={formData.department}
        onChange={handleChange}
        placeholder="Department"
        required
      />
      <input
        name="email"
        value={formData.email}
        onChange={handleChange}
        placeholder="Email"
        required
      />
      <input
        name="salary"
        value={formData.salary}
        onChange={handleChange}
        placeholder="Salary"
        required
        type="number"
      />
      <button type="submit">{current ? "Update" : "Add"} Employee</button>
    </form>
  );
}
