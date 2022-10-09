const ENV = {
  dev: {
    apiUrl: 'http://localhost:44380',
    oAuthConfig: {
      issuer: 'http://localhost:44380',
      clientId: 'Project1_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access Project1',
    },
    localization: {
      defaultResourceName: 'Project1',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44380',
    oAuthConfig: {
      issuer: 'http://localhost:44380',
      clientId: 'Project1_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access Project1',
    },
    localization: {
      defaultResourceName: 'Project1',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
