import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
    {path:"login", component:LoginComponent},
    {path:"about", component:AboutComponent},
    {path:"contact", component:ContactComponent},
    {path:"home", component:HomeComponent}
];
