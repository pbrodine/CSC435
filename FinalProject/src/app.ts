import { HttpClient } from 'aurelia-fetch-client';
import { autoinject } from 'aurelia-framework';

@autoinject
export class App {
  public header = 'Users';
  public users = [];

  constructor(private http: HttpClient) {
    console.log("Init App.ts");
    http.configure(config => {
      config
        .useStandardConfiguration()
                .withBaseUrl('https://brodineassignment7.azurewebsites.net');
    });
  }

  activate() {
    console.log("Fetching users");
    return this.http.fetch("")
      .then(response => response.json())
      .then(users => this.users = users);
  }
}

