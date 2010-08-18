




/*
'===============================================================================
'  LinqHelper.DAO.OkhuVucBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqOkhuVucBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqOkhuVucBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqOkhuVucEntity obj)
		{
			provider.GetTable<LqOkhuVucEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqOkhuVucEntity _obj)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqOkhuVucEntity tmp = q.First<LqOkhuVucEntity>();
			
			tmp.TenOkhuVuc = _obj.TenOkhuVuc;
			tmp.IdThon = _obj.IdThon;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.GhiChu = _obj.GhiChu;
			tmp.LoaiDanhMuc = _obj.LoaiDanhMuc;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.NgayHetHan = _obj.NgayHetHan;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqOkhuVucEntity obj)
		{
			provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTenOkhuVuc(string TenOkhuVuc)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.TenOkhuVuc == TenOkhuVuc
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdThon(Guid IdThon)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.IdThon.Value == IdThon
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByGhiChu(string GhiChu)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.GhiChu == GhiChu
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.LoaiDanhMuc == LoaiDanhMuc
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.NgayHetHan.Value == NgayHetHan
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqOkhuVucEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqOkhuVucEntity ob = (LqOkhuVucEntity)q.First<LqOkhuVucEntity>();
            provider.GetTable<LqOkhuVucEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqOkhuVucEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqOkhuVucEntity>();
		}

		public List<LqOkhuVucEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectByTenOkhuVuc(string TenOkhuVuc)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.TenOkhuVuc == TenOkhuVuc
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectByIdThon(Guid IdThon)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.IdThon.Value == IdThon
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectByGhiChu(string GhiChu)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.GhiChu == GhiChu
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectByLoaiDanhMuc(string LoaiDanhMuc)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.LoaiDanhMuc == LoaiDanhMuc
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectByNgayHetHan(DateTime NgayHetHan)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.NgayHetHan.Value == NgayHetHan
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		public List<LqOkhuVucEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqOkhuVucEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqOkhuVucEntity>();
		}
		
		
		

	}
}
