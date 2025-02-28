import React, { useEffect } from 'react';
import './App.css';
import axios, { AxiosResponse } from 'axios';
import { getAllUrl } from './endpoint';

import { provideFluentDesignSystem, fluentCard, fluentButton } from '@fluentui/web-components';
import { provideReactWrapper } from '@microsoft/fast-react-wrapper';

const { wrap } = provideReactWrapper(React, provideFluentDesignSystem());
export const FluentCard = wrap(fluentCard());
export const FluentButton = wrap(fluentButton());

function App() {

  useEffect(() => {
    axios.get(getAllUrl)
      .then((response: AxiosResponse<any>) => {
        console.log(response.data);
      })
  }, [])

  return (
    <FluentCard>
        <h1>
            House Maintenance Website
        </h1>
        <p> Communicating with an ASP .NET Core server </p>
        <FluentButton appearance="accent" onClick={() => console.log('clicked')}>
            Click Me!
        </FluentButton>
    </FluentCard>
  );
}

export default App;
