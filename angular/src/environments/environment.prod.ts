import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'pvp_ecommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44396/',
    redirectUri: baseUrl,
    clientId: 'pvp_ecommerce_App',
    responseType: 'code',
    scope: 'offline_access pvp_ecommerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44396',
      rootNamespace: 'pvp_ecommerce',
    },
  },
} as Environment;
