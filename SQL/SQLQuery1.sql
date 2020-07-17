Select ([item_name]), coalesce(([cat_name]), 'no cat') as cat_name 
from [Items] 
left join [item_cats] on [Items].[item_id]=[item_cats].[item_id] 
left join [Cats] on [item_cats].[cat_id]=[Cats].[cat_id]