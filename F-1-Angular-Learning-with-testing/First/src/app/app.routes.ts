import { Routes } from '@angular/router';
import { Home } from './components/home/home';
import { About } from './components/about/about';
import { Contact } from './components/contact/contact';
import { PageNotFound } from './components/page-not-found/page-not-found';
import { User } from './components/user/user';

export const routes: Routes = [
  { path: '', component: Home },
  { path: 'about', component: About },
  // { path: 'contact', component: Contact },
  //lazy loading
  {
    path: 'contact',
    loadComponent: () => import('./components/contact/contact').then((c) => c.Contact),
  },
  // { path: 'user/:id', component: User },
  { path: 'user', component: User },
  { path: '**', component: PageNotFound },
];
