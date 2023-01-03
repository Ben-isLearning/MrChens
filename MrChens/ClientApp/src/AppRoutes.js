import { ChangeLog } from "./components/ChangeLog";
import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { RamenShop } from "./components/RamenShop";


const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
    },
  {
   path: '/fetch-data',
   element: <FetchData />
  },
  {
   path: '/change-log',
   element: <ChangeLog />
  },
  {
   path: '/ramen',
   element: <RamenShop />
  },

];

export default AppRoutes;
