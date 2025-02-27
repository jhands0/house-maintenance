import React, { useEffect } from 'react';
import './App.css';
import axios, { AxiosResponse } from 'axios';

function App() {

  useEffect(() => {
    axios.get("Backend_Url")
      .then((response: AxiosResponse<any>) => {
        console.log(response.data);
      })
  }, [])

  return (
    <>
        <h1>
            House Maintenance Website
        </h1>
        <p> Communicating with an ASP .NET Core server </p>
    </>
  );
}

export default App;
