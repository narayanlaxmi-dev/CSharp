import axios from "axios";

const API_BASE_URL = "https://localhost:7029/api/Employees"; // Replace with your backend port

export const getEmployees = () => axios.get(API_BASE_URL);
